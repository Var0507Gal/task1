﻿// Задача 52. Задайте двумерный массив из целых чисел. \
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = ReadInt("Введите номер строки массива А: ");
int colums = ReadInt("Введите номер столбца массива А: ");
int[,] numbers = new int[rows, colums];
FillArray(numbers);
PrintArray(numbers);
Console.Write("Среднее арифметическое каждого столбца: ");

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArrayRes(avgNumbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArrayRes(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}