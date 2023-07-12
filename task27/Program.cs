// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12


int SumX(int numX)
{

    int count = Convert.ToString(numX).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        advance = numX - numX % 10;
        result = result + (numX - advance);
        numX = numX / 10;
    }
    return result;
}
Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());
int sumX = SumX(numX);
Console.WriteLine(sumX);

