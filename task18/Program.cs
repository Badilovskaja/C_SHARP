Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

void GetQuarter(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("X > 0 && Y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("X < 0 && Y > 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("X < 0 && Y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("X > 0 && Y < 0");
    }
}
GetQuarter(number);