/*
// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());
int quartNum = FindQuart(xA, yA);
if (quartNum == 0)
{
    Console.WriteLine("Point on the axes!");
}
else 
{
    Console.WriteLine($"Point is located on {quartNum} quart");
};
*/

/*
// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
 
 void DiapCoordin(int num)
 {
    if (num == 1)
    {
        Console.WriteLine("x > 0 and y > 0");
    };
    if (num == 2)
    {
        Console.WriteLine("x < 0 and y > 0");
    };
    if (num == 3)
    {
        Console.WriteLine("x < 0 and y < 0");
    };
    if (num == 4)
    {
        Console.WriteLine("x > 0 and y < 0");
    };
    if (num < 1 || num > 4)
    {
        Console.WriteLine("Такой четверти не существует");
    };
 }
Console.Write("Input number of quard: ");
int quardNum = Convert.ToInt32(Console.ReadLine());
DiapCoordin (quardNum);
*/

/*
// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
double Length(double x1,  double y1, double x2,  double y2)
{
    double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return l;
}
Console.Write("Напишите координату первой точки по оси Х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату первой точки по оси У: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси Х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси У: ");
double yB = Convert.ToDouble(Console.ReadLine());
double len = Length (xA, yA, xB, yB);
Console.WriteLine($"Длина отрезка равна {len}");
*/

/*
// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.
void Quard (int number)
{
    int i = 1;
    while(i<=number)
    {
        Console.Write(i*i + " ");
        i++;
    }
}
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Квадраты чисел от 1 до " + num + " равны " );
Quard(num);
*/