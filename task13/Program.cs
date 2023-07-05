
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Num1 = Convert.ToInt32(Console.ReadLine());
if (Num1 < 100)
{
    Console.WriteLine("третьей цифры нет ");
}
else
{
    int Num2 = Num1 / 100 % 100;
    Console.WriteLine(Num2);
}
