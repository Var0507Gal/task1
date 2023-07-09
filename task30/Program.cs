// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

// int[] ints1 = new int[8];
// int[] ints2 = new int[8] { 0, 1, 5, 6, 7, 8, 7, 8 };
// int[] ints3 = { 0, 1, 5, 6, 7, 8, 7, 8 };
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
        arr[i] = new Random().Next(2);
    }
}
void ArrayPrinting(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}