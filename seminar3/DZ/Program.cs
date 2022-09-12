// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Enter a five-digit number: ");
int FDN = int.Parse(Console.ReadLine());
if (FDN / 10000 % 10 == FDN % 10 | FDN / 1000 % 10 == FDN / 10 % 10) Console.WriteLine($"{FDN} -> да ");
else Console.WriteLine($"{FDN} -> нет ");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

Console.WriteLine("Задача 21: ");
Console.Write(" Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
double roundDistance = Math.Round(distance, 2);

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {roundDistance}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
if (i != N) Console.Write($"{i*i*i}, ");
else Console.Write($"{i*i*i}");
}