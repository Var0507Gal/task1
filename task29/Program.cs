﻿// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

Console.WriteLine("Введите число длинну массива:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array= new int[number];
ArrayFilling(array);
ArrayPrinting(array);
void ArrayFilling(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100);
    }
}
void ArrayPrinting(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}