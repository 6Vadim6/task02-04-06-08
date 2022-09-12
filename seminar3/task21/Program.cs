// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// d = √((х1 – х2)2 + (у1 – у2)2)

Console.Write("Enter first point coordinates: x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter first point coordinates: y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter second point coordinates: x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter second point coordinates: y2 = ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Distance between first and second point = {Math.Round(Math. Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2)}");