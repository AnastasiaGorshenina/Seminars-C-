
//выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру
/*
int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if(ed>dec)
        max = ed;
    else 
        max = dec;
    return max;
}




int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Biggest digit of {randomNumber} is {biggestDigit}");
*/

//Зад 2 - Вывод случайное трехзн число и удаляет втору цифру этого числа

/*
int CutNumber(int number)

{
    int ed = number % 10;
    int sot = number / 100;

    return sot * 10 + ed;
    
}

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");
*/

// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
/*
void InDivisionable(int num1, int num2)
{
    int reminder = num2 % num1;

    if(reminder== 0)
        Console.WriteLine($"{num2} is divisionable of {num1}");

    else

        Console.WriteLine($"{num2} is not divisionable of {num1}. Reminder is {reminder}");
    
}

Console.Write("Input first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:");
int n2 = Convert.ToInt32(Console.ReadLine());

InDivisionable(n1, n2);
*/

//Задача 4

/*
bool IsDivis(int number)
{
    if(number % 7 == 0 && number % 23 == 0)
        retrurn true;
    else
        return false; 
}       

Console.Write ("");
*/
