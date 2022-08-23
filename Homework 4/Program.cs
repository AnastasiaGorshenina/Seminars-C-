
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B


int powNumber(int numberA, int numberB)
{
    int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    //int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int newNumber = powNumber(numberA, numberB);
  Console.WriteLine($"{newNumber}");




//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum (int number)
{
    
    int sum = 0;
    {

    while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }

        
    }

    return sum;
    

}

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Сумма цифр в числе {a} = {FindSum(a)}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = {1, 2, 5, 7, 19};



void PrintArray(int[] array)
{
    
    int count = array.Length; 
    for (int i = 0; i < count; i++)
    
    {
        Console.WriteLine($"{array[i]}");
        
    }
}
PrintArray(arr);

