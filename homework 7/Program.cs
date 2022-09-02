//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
void CreatArrayOfRealRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
CreatArrayOfRealRandomNumbers(numbers);
Show2dArray(numbers);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] =new Random().Next(-100, 100)/10;
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

void InputAndReturnElem(int[,] array, int rows, int columns)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (rows > array.GetLength(0) || columns > array.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {array[rows-1, columns-1]}");
            }   
        }    
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
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
InputAndReturnElem(myArray, m, n);



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
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

  void avgOfColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int j = 0; j < columns; j++)
    {
        double avg = 0;
        for (int i = 0; i < rows; i++)
        {
            avg = (avg + array[i, j]);
        }
        avg = avg / columns;        
        Console.Write(avg + " ");
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

int[,] myArray = CreateRandom2dArray(m, n, min,max);
Show2dArray(myArray);
avgOfColumns(myArray);

*/




































