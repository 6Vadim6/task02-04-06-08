// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Enter number: ");
int number1 = int.Parse(Console.ReadLine());
int number = Math.Abs(number1);

int Getcount(int number)
{
    int count = 0;
    while (number > 10)
    {
        number = number / 10;
        count++;
    }
    return count+1;
}

Console.WriteLine($"{number1} -> {Getcount(number)}");