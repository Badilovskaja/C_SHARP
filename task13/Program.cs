
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Num1 = Convert.ToInt32(Console.ReadLine());
// if (Num1 < 100)
// {
//     Console.WriteLine("третьей цифры нет ");
// }
// else
// {
//     int Num2 = Num1 / 10;
//     // int res = Num2 % 10;
//     Console.WriteLine(Num2);
// }
// .................или

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
