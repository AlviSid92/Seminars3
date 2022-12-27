// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int rows = ReadInt("Введите количество строк: ");
// int colums = ReadInt("Введите количество столбцов: ");
// double[,] num = new double[rows, colums];
// FillArray2D(num);
// PrintArray2D(num);

// void FillArray2D(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-99, 99) /10.0;
//         }
//     }
// }

// void PrintArray2D(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string mes)
// {
//     Console.Write(mes);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] num = new int[6, 8];
// FillArray2D(num);
// PrintArray2D(num);

// if (rows < num.GetLength(0) && colums < num.GetLength(1)) Console.WriteLine(num[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



int rows = 5;
int colums = 5;
int[,] num = new int[rows, colums];
FillArray2D(num);
PrintArray2D(num);

double[] avgnum = new double[num.GetLength(1)];

for (int i = 0; i < num.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < num.GetLength(0); j++)
    {
        result += num[j, i];
    }
    avgnum[i] = result / num.GetLength(0);
}
PrintArray(avgnum);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}