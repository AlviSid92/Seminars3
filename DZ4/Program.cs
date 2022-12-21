// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Stepen(int A, int B)
// {
//     int result = 1;
//     for( int i = 1; i <= B; i++)
//     {
//         result = result * A;
//     }
//     return result;
// }
// Console.WriteLine("Введите число:");
// int A = Convert.ToInt32(Console.ReAdLine());
// Console.WriteLine("Введите число:");
// int B = Convert.ToInt32(Console.ReAdLine());
// int stepen = Stepen(A, B);
// Console.WriteLine(stepen);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int numlin(int A)
// {
//     int index = 0;
//     while (A > 0)
//     {
//         A /= 10;
//         index++;
//     }
//     return index;
// }

// void sumlin(int n, int lin)
// {
//     int sum = 0;
//     for (int i = 1; i <= lin; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }
// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int lin = numlin(A);
// sumlin(A, lin);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.Write("Полученный массив:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число массива:");
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(lenght, min, max));