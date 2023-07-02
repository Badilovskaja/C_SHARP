Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
    Console.WriteLine($"max = `{numA}`");
else
{
    Console.WriteLine($"max = `{numB}`");
}

