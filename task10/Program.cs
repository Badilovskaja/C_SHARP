// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Num1 = Convert.ToInt32(Console.ReadLine());
int result = Num1 / 10 % 10;
Console.WriteLine(result);

// ю................или
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число. Введите трехзначное число");
    return;
}
Console.WriteLine($"число`{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"вторая цифра`{secondRank}`");