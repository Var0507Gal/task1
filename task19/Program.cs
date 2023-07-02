// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int t = 0;
int r = 0;
int sum = 0;
if(number > 9999 && number < 100000)
{
for(t = number; number != 0; number = number / 10)
{
r = number % 10;
sum = sum*10+r;
}
if(t == sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число!");