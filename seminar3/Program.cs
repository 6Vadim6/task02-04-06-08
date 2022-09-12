// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Enter number of quarter ");
int quarter = int.Parse(Console.ReadLine());
Console.Clear();
if (quarter == 1) Console.WriteLine($"x > 0; y > 0");
if (quarter == 2) Console.WriteLine($"x < 0; y > 0");
if (quarter == 3) Console.WriteLine($"x < 0; y < 0");
if (quarter == 4) Console.WriteLine($"x > 0; y < 0");