// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите число от 1 до 7:");
int a = int.Parse(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (a > 0 && a < 8) {
	Console.WriteLine(weekDays[a-1]);
}
else {
	Console.WriteLine("Не путай меня");
}