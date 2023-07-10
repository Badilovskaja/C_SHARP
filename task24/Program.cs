// ................напишите програму принимающую на вход число(а) и выдающую сумму чисел  от 1 до (а)


int GetSumOfSeries(int from, int to)
{
    int result = 0;
    for (int i = from; i <= to; i++)
    {
        result = result + i;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = GetSumOfSeries(1, number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");