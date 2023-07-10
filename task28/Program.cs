//Написать програму принимаюшую число (А) и выводящее произведение чисел от 1 до (А)
// Факториал числа А! = 1*2*3*4...А
int Base(int from, int to)
{
    int product = 1;
    for (int i = from; i <= to; i++)
    {
        product *= i;
    }
    return product;
}
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int result = Base(1, value);
Console.WriteLine($"ответ - {result}");
