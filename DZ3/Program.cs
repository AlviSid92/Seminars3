// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


// void palindrom()
// {
//     Console.Write("ведите число из 5 символов ");
//     int number = Convert.ToInt32(Console.ReadLine()); 
//     int num1 = number / 10000 % 10;
//     int num2 = number / 1000 % 10;
//     int rev1 = number / 10 % 10;
//     int rev2 = number % 10;
//     int nul = number / 10000;
        
//     if (nul < 1 || nul > 9)
//     {
//         Console.WriteLine(number + " -> " + "тут не пять символов");
//     }
//         else if  (num1 == rev2 && num2 == rev1)
//         {
//             Console.WriteLine(number + " палиндром");
//         }
//         else
//         {
//             Console.WriteLine(number + " не палиндром");
//         }
//         }
//         for (int i = 0; i < 10; i++)
//         { 
//             palindrom();
//     }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// void Distanse(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double result = Math.Round(Math.Sqrt (Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),3);
//     Console.WriteLine(result);
// }
// Console.WriteLine("Ось Х1:");
// double Ax = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ось Y1:");
// double Ay = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ось Z1:");
// double Az = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ось Х2:");
// double Bx = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ось Y2:");
// double By = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Ось Z2:");
// double Bz = Convert.ToDouble(Console.ReadLine());
// Distanse(Ax, Ay, Az, Bx, By, Bz);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N


// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i*i*i} ");
// }
