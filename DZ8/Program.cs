//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] table = new int[4, 4];

// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// FillArrayRandom(table);
// PrintArray(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] array3D = new int[2, 2, 2];

// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
// FillArray(array3D);
// PrintIndex(array3D);

//Напишите программу, которая заполнит спирально массив 4 на 4.


void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);