// задача 24
// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А
Console.WriteLine("Введите целое число A: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {sumNumber}");
int SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }  
    return sum;
}
