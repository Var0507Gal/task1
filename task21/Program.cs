// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1: ");
Console.Write("X1= ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1= ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1= ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
Console.Write("X2= ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2= ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2= ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

int a = xCoordinate2 - xCoordinate1;
int b = yCoordinate2 - yCoordinate1;
int c = zCoordinate2 - zCoordinate1;

double l = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine($" Растояние между точкой 1 и 2: {l}");