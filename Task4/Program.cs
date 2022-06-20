double a, b, c;

Console.Write("Введите 1 число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 число: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 3 число: ");
c = Convert.ToDouble(Console.ReadLine());

double max = a;

if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}

Console.WriteLine("Максимальное число: "+ max);
