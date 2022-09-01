// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите два числа: ");
string[] num = Console.ReadLine().Split(' ');
int a = int.Parse(num[0]);
int b = int.Parse(num[1]);
if (a > b) Console.WriteLine($"{a}");
else Console.WriteLine($"{b}");