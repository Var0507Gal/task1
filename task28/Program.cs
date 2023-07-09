// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = Multiple(number);
        Console.WriteLine($"Произведение чисел от 1 до {number} (Факториал) равно {result}");
        int Multiple(int num)
        {
            int mult = 1;
            for (int i = 1; i <= num; i++)
            {
                checked
                {
                mult *= i;
                }
            }
            return mult;
        }
    }
}