//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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

void FindColNumbers (int[] array)
{
    int current = 0;
    int col = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        col = col + array[i];

        else 
            current++;
    }

    
    Console.WriteLine("col of elements > 0 is " + current);
}
Console.WriteLine();
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray (a);
ShowArray(myArray);
FindColNumbers(myArray);
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void FindCrossPoint (double k1, double k2, double b1, double b2)
{
double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;

Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
FindCrossPoint(k1,k2,b1,b2);
*/
