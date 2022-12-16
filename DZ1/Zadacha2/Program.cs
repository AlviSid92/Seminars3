Console.WriteLine("Для сравнения введите два числа:");
int a, b;
Console.WriteLine("Число один:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число два:");
b = Convert.ToInt32(Console.ReadLine());
bool C1 = a > b , C2 = a == b , C3 = a < b;

if(C1)
{
    Console.WriteLine($"Number {a} > {b}");
}
else if(C2)
{
    Console.WriteLine($"Number {a} = {b}");
}
else
{ 
    Console.WriteLine($"Number {a} < {b}");
}