﻿
// Задача 1
/*
int a = 5;
int b = 7;

int max = a;
if (b > max) max = b;

Console.WriteLine(max);
*/

/*
int a = 2;
int b = 10;

int max = a;
if (b > max) max = b;

Console.WriteLine(max);
*/

/*
int a = -9;
int b = -3;

int max = a;
if (b > max) max = b;

Console.WriteLine(max);
*/

// Задача 2
/*
int n1 = 2;
int n2 = 3;
int n3 = 7;
int max = n1;
    if(n2 > max ) max = n2;
    if(n3 > max ) max = n3;

Console.WriteLine(max);
*/

/*
int n1 = 44;
int n2 = 5;
int n3 = 78;
int max = n1;
    if(n2 > max ) max = n2;
    if(n3 > max ) max = n3;

Console.WriteLine(max);
*/

/*
int n1 = 22;
int n2 = 3;
int n3 = 9;
int max = n1;
    if (n2 > max) max = n2;
    if (n3 > max) max = n3;

Console.WriteLine(max);
*/
 
// Задача 3
/*
Console.Write("Input number:");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.Write($"{n} is  {n % 2 == 0} ");
}
else
{
    Console.Write($"{n} is not  {n % 2 == 0}");
}
*/

// Задача 4
Console.Write("Введите число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int current = 1;
int ed = numberN / 2;

while(current <= numberN)
{
  Console.Write(ed + " ");  
  ed+=2;
}


 

 

  