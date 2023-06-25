// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0 || number > 7)
{
    Console.WriteLine($"Ошибка ввода, {number} - неверное число. Число должно быть от 1 до 7");
}
else
{
    if (number > 5)
    {
        Console.WriteLine($"Введенное число {number} - выходной день");
    }
    else
    {
        Console.WriteLine($"Введенное число {number} - рабочий день");
    }
}