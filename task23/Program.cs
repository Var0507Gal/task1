// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов: {n}");
for (int i = 1; i <= n; i++)
{
int k = i*i*i;
Console.Write($"{k}");
}