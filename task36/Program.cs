// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayFilling(numbers);
Console.WriteLine("Полученный массив: ");
ArrayPrinting(numbers);
int sum = 0;
for (int i = 1; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"Всего в массиве {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void ArrayFilling(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void ArrayPrinting(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}