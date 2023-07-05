// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));