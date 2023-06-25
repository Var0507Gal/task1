// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
