//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void sortingOfArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}    
Console.WriteLine();

Console.Write("Input number of rows: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
sortingOfArray(myArray);
Show2dArray(myArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
int SumOfElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

void RowsWithMinSum (int[,] array)
{
   int minSum = 0;
   int RowMinSum = SumOfElements(array, 0);
   {
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = SumOfElements(array, i);
        if (RowMinSum > tempSum)
        {
            RowMinSum = tempSum;
            minSum = i;
        }
    }
   }
   Console.WriteLine($"{minSum+1} is row with minsum elements({RowMinSum}) ");
}   

Console.Write("Input number of rows: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min,max);
Show2dArray(myArray);
RowsWithMinSum(myArray);

*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
            Console.Write(a[i,j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] ArrayA = CreateRandom2dArray(m, n, min, max);
Show2dArray(ArrayA);


int[,] CreateRandom2dArray1(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray1(int[,] b)
{
    for(int i = 0; i < b.GetLength(0); i++)
    {
        for(int j = 0; j < b.GetLength(1); j++)
            Console.Write(b[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] ArrayB = CreateRandom2dArray1(m, n, min, max);
Show2dArray1(ArrayB);




    int[,] c = new int[2, 2];
    for(int i = 0; i < ArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayB.GetLength(0); j++)
        {
            c[i,j]=0;
            for (int k = 0; k < 2; k++)
            {
                c[i, j] +=  ArrayA[i, k] * ArrayB[k, j];
            }
        }
        

    }
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(c[i, j]+" ");
        }
        Console.WriteLine();
    }


*/