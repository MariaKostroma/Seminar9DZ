//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);

void NaturalToLow(int n, int count)
{
    if(count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.


Console.WriteLine();
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Console.Write(sumNM(m - 1, n));
}
 
int sumNM(int m, int n)
{
    int res = m;
    if(m == n)
        return 0;
    else
    {
        m++;
        res = m + sumNM(m,n);
        return res;
    }
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 

Console.WriteLine();
Console.Write("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m1,n1);

void AkkermanFunction(int m1, int n1)
{
    Console.Write(Akkerman(m1, n1)); 
}

int Akkerman(int m1, int n1)
{
    if (m1 == 0)
    {
        return n1 + 1;
    }
    else if (n1 == 0 && m1 > 0)
    {
        return Akkerman(m1 - 1, 1);
    }
    else
    {
        return (Akkerman(m1 - 1, Akkerman(m1, n1 - 1)));
    }
}