Console.WriteLine("Введите число чтоб узнать четное или нет");
int a;
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}
