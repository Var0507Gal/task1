// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = LengthNumber(number);
Console.WriteLine($"Количество цифр в числе {number}: {result}");

int LengthNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count == 0 ? 1 : count;
}