
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Введите числа через запятую: ");
// string num = Console.ReadLine();
// int[] num2 = ParseStringToArray(num);
// PrintArray(num2);

 
// int Comparison(int[] Numbers)
// {
//   int count = 0;
//   for (int i = 0; i < num2.Length; i++)
//   {
//     if(Numbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }
 
// Console.WriteLine($"Чисел больше нуля: {Comparison(num2)} ");

// int[] ParseStringToArray(string num)
// {
//     int countNumbers = GetCountNumbersInString(num);
//     int[] num2 = new int[countNumbers];
//     int indexNumber = 0;
//     string substring = string.Empty;
//     for (int i = 0; i < num.Length; i++)
//     {
//         if (num[i] != ',')
//         {
//             substring += num[i];
//         }
//         else
//         {
//             num2[indexNumber] = Convert.ToInt32(substring);
//             indexNumber++;
//             substring = string.Empty;
//         }
//     }
//     if(num[num.Length - 1] != ',')
//         num2[indexNumber] = Convert.ToInt32(substring);
//     return num2;
// }
// int GetCountNumbersInString(string num) 
// {
//     int count;
//     if(num[num.Length - 1] == ',')
//         count = 0;
//     else
//         count = 1;

//     for(int i = 0; i < num.Length; i++)
//     {
//         if(num[i] == ',')
//             count++;
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("B1");
// double B1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("K1");
// double K1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("B2");
// double B2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("K2");
// double K2 = Convert.ToInt32(Console.ReadLine());

// double numberX = (B2 - B1)/(K1 - K2);
// double numberY = K2 * numberX + B2;

// Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");