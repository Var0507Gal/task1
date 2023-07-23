// // Задача 68: Напишите программу вычисления функции Аккермана 
// // с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления функции Аккермана при прееменных M = {m} и N = {n} равно {Akkerman(m, n)}");
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
