﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int B = 2;

if(N > 1)
{
    while(B <= N)
    {
        Console.Write(B + " ");
        B = B + 2;
    }
}