//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

// void PrintNum(int num)
// {
//     if(num>=1)
//     {
//         Console.Write(num+" ");
//         PrintNum(num-1);
        
//     }
// }

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintNum(num);


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// void SumNum(int m, int n)
// {
//     Console.Write(SumNum1(m - 1, n));
// }

// int SumNum1(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumNum1(m, n);
//         return res;
//     }
// }
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumNum(m, n);

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);