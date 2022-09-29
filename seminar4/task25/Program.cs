// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine($"\nTask 25. Raising a number A to a natural power B");

int MathPow(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Please, enter first number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Please, enter second number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = MathPow(numberA, numberB);
  Console.WriteLine($"Answer: {numberA}, {numberB} -> " + exponentiation);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine($"\nTask 27. Returns the sum of the digits in a number");
Console.Write("Please, enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumDigits(int number){
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumDigits(number);
Console.WriteLine($"Answer: {number} -> " + sumNumber);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\nTask 29. A series of numbers converts to an array");
Console.Write("Enter a series of numbers separated by a comma : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Character input error. Please, enter numbers.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArray(arrayOfNumbers);