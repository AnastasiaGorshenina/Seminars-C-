// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую ее цифру в этом числе

/*
int FindbiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if(ed > dec)
    {
        max = ed;
    }
    else 
    {
        max = dec;
    }
    return max;
}


int randomNumber = new Random().Next(10,100);

int biggestDigit = FindbiggestDigit(randomNumber);

Console.WriteLine($"Biggest digit of {randomNumber} is {biggestDigit}");
*/

// Задача2. Напишите программу, котороф выводит случайное трехзначное число  и удаляет вторую цифру этого числа
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;


}

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}" );
*/

//Задача3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
void IsDivisionnable(int num1, int num2)
{
    
    int reminder = num2 % num1;


    if (reminder == 0)
    {
        Console.WriteLine($"{num2} is divisionable of {num1}");
    }
    else
    {
        Console.WriteLine($"{num2} is not divisionable of {num1}. Reminder is {reminder}");
    }
}

Console.Write("Input first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionnable(n1,n2);
*/

//Задача 4. Напишите программу, которая на входпринимает число и проверяет, кратно ли оно одновременно двум числам

bool IsDivis(int number)
{
    if(number % 7 == 0) 
    if(number % 23 ==0)
        return true;
    else
        return false;

}

Console.Write("Input number:");
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision = IsDivis(n);
 Console.WriteLine(IsDivision);   