
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 /*
 int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray  = new int[size];
    

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    
    }
    Console.WriteLine(); 
}

void FindEvenCount(int [] array)
{
    int sumeventCount = 0;
    int evenCount = 0;

    for (int i= 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
           sumeventCount = sumeventCount + array[i];
        else
            evenCount++;   
    }
    Console.WriteLine("sum of evenCount is: " + evenCount);
    
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value for element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value for element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindEvenCount(myArray);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray  = new int[size];
    

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    
    }
    Console.WriteLine(); 
}

void FindSumNumberOfOddIndex(int [] array)
{
    int sum= 0;
    

    for (int i= 1; i < array.Length; i+=2)
    {
        if(i % 2 > 0)
           sum = sum + array[i];
        else
            i+=2;   
    }
    Console.WriteLine("сумма ровна" + sum);
    
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value for element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value for element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindSumNumberOfOddIndex(myArray); 
*/



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
        }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindMinMaxDif(int[] array)
{
    int dif = 0;
    int max = array[0];
    int min = array [0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    dif = max - min;
    Console.WriteLine("Dif of max and min elements is " + dif);
    
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray (a);
ShowArray(myArray);
FindMinMaxDif(myArray);

*/    