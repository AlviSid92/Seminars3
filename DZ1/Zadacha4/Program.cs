// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Ввести три числа для нахождения max:");
// int a , b , c;
// Console.WriteLine("Первое:");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Второе:");
// b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Третье:");
// c = Convert.ToInt32(Console.ReadLine());


// int max = a;

// if (a > max) max = a;
// if ( b > max) max = b;
// if (c > max ) max = c;

// Console.Write("max = ");
// Console.WriteLine(max);




int[] CreateRandomArray(int n, int a, int b)
  {
      int[] myArray = new int[n];
      myArray[0] = a;
      myArray[1] = b;
      for (int i = 2; i < n; i++)
      {
           myArray[i] = myArray[i-2] + myArray[i-1];
      }
      return myArray;
 }

  void ShowArray(int[] array)
 {
      Console.WriteLine("Полученный массив ->:");
      for (int i = 0; i < array.Length; i++)
      {
          Console.Write(array[i] + " ");
      }
      Console.WriteLine();
 }


 Console.WriteLine("Введите размер массива:");
 int lenght = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите первый элемент массива:");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второй элемент массива :"); 
 int b = Convert.ToInt32(Console.ReadLine());                                  

 int[] newArray = CreateRandomArray(lenght,a,b);

 ShowArray(newArray);

