﻿// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write($"Четные цифры при введеной цифре {number} будут ");
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count = count + 1;
}