//Задача 1. Программа  выдает на консоль сумму чисел от 1 до N
 /*
int FindSum (int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++)
    {
        sum = sum + current;

    }
    return sum;
}

Console.Write("Input integer number");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
*/

//Принимает на вход число и выдает количество цифр
/*
int FindDigets (int number)
{
    int current = 0;
    while (number > 0)
    {
        number = number / 10;
        current ++;

    }
    return current;
}
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {a} = {FindDigets(a)}");
*/

// Найти факториал
/*
int FindFactorial(int number)
{
    int factorial = 1;

    for (int current = 1; current <= number; current++ )
    {
        factorial = current * factorial;

    }
    return factorial;
}
Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Сумма чисеa от 1 до {a} = {FindFactorial(a)}"); 
*/

// Напишите программу, которая выводит массив
// из 8 элементов, заполненный 
// нулями и единицами в случайном порядке

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray  = new int[size];
    

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possibleValue element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possibleValue element: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max) ;

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine(); 
}

ShowArray(myArray);