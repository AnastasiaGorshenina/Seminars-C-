//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


/*
void Metod(int n, int m)
{
    if(m != n)
    {
    if (n > m) 
        {
            Metod (n - 1, m);
            Console.Write(n + " ");
        }
    else
        {
            Metod(n, m - 1);
            Console.Write(m + " ");
        }
    
    } 
    else
    Console.Write(m + " ");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number: ");
int m = Convert.ToInt32(Console.ReadLine());
Metod(n, m);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(" Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());


void SumNumbers(int m, int n)
{
    Console.Write(FindSum(m - 1, n));
}
SumNumbers(m, n);


int FindSum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + FindSum(m, n);
        return res;
    }
}
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
Console.Write("Input number n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  number m: ");
int m = Convert.ToInt32(Console.ReadLine());

int AkkFunct (int n, int m)
{
    if(n==0)

    return m+1;

    else
    {
        if((n != 0) && (m==0))
        
        return AkkFunct(n-1, 1);

        else

        return AkkFunct(n-1, AkkFunct(n,m - 1));
    }

}
Console.WriteLine(AkkFunct(n, m));

*/