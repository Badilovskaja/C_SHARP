Console.Write("Введите 1 число - ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число - ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;
if (result == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine($" остаток {result}");
}
