// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Чтение данных из консоли

int number = ReadData("Введите натуральное число N: ");
if (number < 1)
{
    Console.WriteLine("Вы ввели отрицательное число число");
}
string resultLine = LineGenRec(number);
PrintResult(resultLine);
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix)
{
    Console.WriteLine($"Рекурсия от числа {number} до 1 будет следующей {prefix}");
}


string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return num + " " + LineGenRec (num - 1);
    }
}

