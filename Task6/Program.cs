﻿int a;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

if(a%2==0)
{
    Console.WriteLine(a + " - четное число");
}
    else
{
    Console.WriteLine(a + " - нечетное число");
}