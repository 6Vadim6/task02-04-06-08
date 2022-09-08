// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Enter three-digit number ");
int num = int.Parse(Console.ReadLine());
int second = num / 10 % 10;
if (num >= 100 & num <= 999) Console.WriteLine($"{num} -> {second}");
else if (num >= -999 & num <= -100) Console.WriteLine($"{num} -> {second*-1}");
else Console.WriteLine($"{num} -> Please, enter three-digit number ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15 ");

Console.Write("Enter a number from 1 to 7: ");
int a = int.Parse(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (a == 6) Console.WriteLine($"{a} -> да");
else if (a == 7) Console.WriteLine($"{a} -> да");
else if (a < 1 | a > 7) Console.WriteLine("Please, enter a valid number from 1 to 7: ");
else Console.WriteLine($"{a} -> нет");
