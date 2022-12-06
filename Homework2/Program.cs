//Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false)
    {
        Console.WriteLine("Пиши число !");
    }
}
int num = number;
void Week(int num)
{
    if (num < 100)
    {
        Console.Write("третьей цифры нет");
    }
        else if (num < 1000)
    {
        int lastDitgit = num % 10;
        Console.WriteLine(lastDitgit);
    }
        else if (num < 10000)
    {
        int lastDitgit = num % 100 / 10 ;
        Console.WriteLine(lastDitgit);
    }
        else if (num < 100000)
    {
        int lastDitgit = num % 1000 / 100;
        Console.WriteLine(lastDitgit);
    }
        else if (num < 1000000)
    {
        int lastDitgit = num % 10000 / 1000;
        Console.WriteLine(lastDitgit);
    }
        else if (num < 10000000)
    {
        int lastDitgit = num % 100000 / 10000;
        Console.WriteLine(lastDitgit);
    }
        else if (num < 100000000)
    {
        int lastDitgit = num % 1000000 / 100000;
        Console.WriteLine(lastDitgit);
        Console.WriteLine("Остановись, тебе не нужно такое число.");
    }
        else if (num < 1000000000)
    {
        int lastDitgit = num % 10000000 / 1000000;
        Console.WriteLine(lastDitgit);
        Console.WriteLine("Ты дошел до конца, поздравляю..");
    }
}
Week(num);