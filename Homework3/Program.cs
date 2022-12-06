//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введи цифру, обозначающую день недели:");
bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
if (isParsed == false)
    {
        Console.WriteLine("Пиши число от 1 до 7");
    }
}
int num = number;

void Week (int num) {
if (num == 1) { 
    Console.Write("Понедельник -");
    }
    else if (num == 2) {
    Console.Write("Вторник -");
    }
    else if (num == 3) {
    Console.Write("Среда -");
    }
    else if (num == 4) {
    Console.Write("Четверг -");
    }
    else if (num == 5) {
    Console.Write("Пятница -");
    }
    else if (num == 6) {
    Console.Write("Суббота -");
    }
    else if (num == 7) {
    Console.Write("Воскресенье -");
    }
}

Week(num);
void TheDay (int num) {
  if (num == 6 || num == 7) {
  Console.Write(" Это выходной день");
  }
  else if (num < 1 || num > 7) {
    Console.WriteLine("День недели от 1 до 7 (Понедельник - Воскресенье)");
  }
  else Console.Write(" Этот день не выходной");
}

TheDay(num);