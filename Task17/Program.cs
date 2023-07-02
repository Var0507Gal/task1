// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите координаты точки: ");
Console.Write("X= ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());
// if (xCoordinate > 0 && yCoordinate > 0)
// {
//     Console.WriteLine($"Указанные координаты X= {xCoordinate} и Y = {yCoordinate} соответствуют четверти 1");
// }
// else if (xCoordinate < 0 && yCoordinate > 0)
// {
//     Console.WriteLine($"Указанные координаты X= {xCoordinate} и Y = {yCoordinate} соответствуют четверти 2");
// }
// else if (xCoordinate < 0 && yCoordinate < 0)
// {
//     Console.WriteLine($"Указанные координаты X= {xCoordinate} и Y = {yCoordinate} соответствуют четверти 3");
// }
// else if (xCoordinate > 0 && yCoordinate < 0)
// {
//     Console.WriteLine($"Указанные координаты X= {xCoordinate} и Y = {yCoordinate} соответствуют четверти 4");
// }
// else
// {
//     Console.WriteLine("введены не корректные координаты");
// }


int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
        ? $"Указанные координаты X= {xCoordinate} и Y = {yCoordinate} соответствуют четверти {quarter}" 
        : "Введены не корректные координаты";
Console.WriteLine(result);
int Quarter(int x, int y)

{
    if (xCoordinate > 0 && yCoordinate > 0) return 1;
    if (xCoordinate < 0 && yCoordinate > 0) return 2;
    if (xCoordinate < 0 && yCoordinate < 0) return 3;
    if (xCoordinate > 0 && yCoordinate < 0) return 4;
    return 0;
}