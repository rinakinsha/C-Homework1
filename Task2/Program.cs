double a, b;
Console.Write("Введите 1 число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 число: ");
b = Convert.ToDouble(Console.ReadLine());


if (a>b)
{
    Console.WriteLine("max = "+ a);
    Console.WriteLine("min = "+ b);
}
if (a<b)
{
    Console.WriteLine("max = "+ b);
    Console.WriteLine("min = "+ a);
}
if (a==b)
{
    Console.WriteLine("Числа равны");
}
