﻿// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <=999)
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра трехзначного числа {number}: {secondDigit}");
}
else
{
    Console.WriteLine($"Число {number}, не трехзначное");
}

