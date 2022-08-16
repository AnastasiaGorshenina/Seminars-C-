// программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка
/*
int FindQuart(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    
    return 0;
    
}

Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine()); 

int quartNum = FindQuart(xA, yA);

if (quartNum == 0)
    Console.WriteLine("point on the axes!");
else 

    Console.WriteLine($"Point is located on {quartNum} quart");
*/


// По заданному номеру четверти показывает примерные координаты

/*
void FindCoordinats(int quart)
{
    if (quart == 1)
    Console.WriteLine("Диапозон (х+, y+)");
    if (quart == 2)
    Console.WriteLine("Диапозон (х-, y+)");
    if (quart == 3)
    Console.WriteLine("Диапозон (х-, y-)");
    if (quart == 4)
    Console.WriteLine("Диапозон (х+, y-)");
}

Console.Write("Input number of quart: ");
int quart =  Convert.ToInt32(Console.ReadLine());
FindCoordinats(quart);
*/
