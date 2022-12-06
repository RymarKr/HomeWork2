//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число");
bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
if (isParsed == false)
    {
        Console.WriteLine("Пиши трёхзначное число !");
    }
}
int num = number;
int firstDitgit = num / 100;
int lastDitgit = num % 10;
int newDitgit = firstDitgit * 100 + lastDitgit;
int secondDitgit = (num - newDitgit) / 10 * 1;
Console.WriteLine(secondDitgit);
