Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Четное " + num);
}
else
{
    Console.WriteLine("Нечетное " + num);
}