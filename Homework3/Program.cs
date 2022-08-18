

// Задача 19ю Напишите программу, которая на вход принимает число и проверяет, является ли оно палиндромом.
/*
bool isPalindrome (int number)
{
    if(number % 11 == 0 ) 
        return false;
    else
        return true;

}

Console.Write("Input number:");
int n = Convert.ToInt32(Console.ReadLine());

bool palindrom = isPalindrome(n);
 Console.WriteLine(palindrom);   
 */


// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
/*
void TubleCubs (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"куб числа {i} = {i*i*i}");

    }
    
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
TubleCubs(n);
*/

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double zb = Convert.ToDouble(Console.ReadLine());


double coordinate = FindDistance(xa, xb, ya, yb, za, zb);
Console.WriteLine($"Distance is {coordinate}");

*/


