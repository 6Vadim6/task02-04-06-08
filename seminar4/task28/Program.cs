// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Enter number N: ");
int number = int.Parse(Console.ReadLine());

int Factorial(int num)
{
    int count = num;
    while (count > 1)
    {
        count--;
        num *= count;
        Console.WriteLine(num);
    }
    return num;
}

Console.WriteLine($"{number} -> {Factorial(number)}");