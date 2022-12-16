Console.WriteLine("Ввести три числа для нахождения max:");
int a , b , c;
Console.WriteLine("Первое:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье:");
c = Convert.ToInt32(Console.ReadLine());


int max = a;

if (a > max) max = a;
if ( b > max) max = b;
if (c > max ) max = c;

Console.Write("max = ");
Console.WriteLine(max);
