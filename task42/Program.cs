// Напишите программу которая будет преобразовывать десятичные числа в дваичные


Console.WriteLine("введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int binary = 0;
int shift = 1;
while (value != 0)
{
    binary += value % 2 * shift;
    shift *= 10;
    value /= 2;
}
Console.Write(binary);