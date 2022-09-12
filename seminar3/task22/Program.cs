// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
Console.Write($"{N} -> ");

while (count < N & count >= 1)
{
    Console.Write($"{Math.Pow((count), 2)}, ");
    count++;
}
if (count == N)
{
    Console.Write($"{Math.Pow((count), 2)}");
}