// Написать функцию принимающую число и выдающую количество цифр в числе
int AmountOfDigits(int num)
{
    int amount = 0;
    while (num > 0)
    {
        num /= 10;
        amount++;
    }
    return amount;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {number} = {AmountOfDigits(number)}");
