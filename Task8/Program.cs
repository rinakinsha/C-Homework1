﻿Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int n = 1;

while (n<=N)
{
    if(n%2==0)
    {
        Console.Write(n + " ");
    }
n++;    
}