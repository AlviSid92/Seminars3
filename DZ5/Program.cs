// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// int count = 0;
// FillArrayRandomNumbers(num);
// PrintArray(num);

// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] % 2 == 0)
//     count++;
// }


// Console.WriteLine($"Четные: {count} ");

// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int size = 4;
// int[] num = new int[size];
// FillArrayRandomNumbers(num);
// PrintArray(num);

// int sumNum = 0;

// for (int i = 1; i < num.Length; i += 2)
// {
//     sumNum += num[i];
// }
// Console.Write(sumNum);



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int size = 10;
// int[] num = new int[size];
// FillArrayRandomNumbers(num);
// PrintArray(num);

// int max = num[0];
// int min = num[0];

// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] > max)
//     {
//         max = num[i];
//     }
//     else if (num[i] < min)
//     {
//         min = num[i];
//     }
// }

// Console.WriteLine($"Самое маленькое: {min}");
// Console.WriteLine($"Самое большое: {max}");
// Console.WriteLine($"Разница: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }