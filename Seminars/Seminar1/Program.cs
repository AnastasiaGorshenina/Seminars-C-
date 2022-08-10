//Пример 1
/*
 num = 5;

Console.WriteLine(num);
*/

//Пример 2
/*
int num = 5;

Console.WriteLine("My number is" + num);
*/

// Пример 3

/*
int num;

Console.Write("ВВедите число:");
num = Convert.ToInt32(Console.ReadLine());
*/

//Задача 1. - На вход принимает число и выдает ее квадрат

/*
Console.Write("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

Console.WriteLine("The quadrat of" + num + "is" + quad);
                      //ЛИБO
Console.WriteLine($"The quadrat of {num} is {quad}");
*/

// Задача 2. Напишите программу которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
/*
Console.Write("Input first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2*n2;

if(n1==quad2)
{
    Console.Write($"{n1} is quad of {n2}");
}
else
{
    Console.Write($"{n1} is not  quad of {n2}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые от отрицательной версии числа до самого числа

Console.Write("Input integer positive number:");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)
{
  Console.Write(current + " ");  
  current++;
}


// Задача 4. Напишите программу которая на вход принимает трехзначное  число и на выход показывает последнюю цифру
/*
Console.Write("Input integer three-digit number:");
int number = Convert.ToInt32(Console.ReadLine());

int ed = number % 10;

Console.WriteLine($"The last digit  of {number} is {ed}");
*/