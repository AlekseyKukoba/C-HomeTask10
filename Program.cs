// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
else
{
    Console.WriteLine($"Введенное число '{number}'");
    int SecondRank = number / 10 % 10;
    Console.WriteLine($"Вторая цифра '{SecondRank}'");
}
