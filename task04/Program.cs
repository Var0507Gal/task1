// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"среди чисел {number1} , {number2} и {number3} максимальным является число {max}");
