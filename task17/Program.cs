// .....программа которая принимает X Y и выдает номер четверти нахождения точки: 1 2 3 4
int GetNumberOfQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
    {
        result = 1;
    }
    else if (x < 0 && y > 0)
    {
        result = 2;
    }
    else if (x < 0 && y < 0)
    {
        result = 3;
    }
    else if (x > 0 && y < 0)
    {
        result = 4;
    }
    return result;
}

Console.WriteLine("введите переменную Х ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите переменную Y ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX} : {userY}] находится в {quarter} плоскости");
}
else
{
    Console.WriteLine($"Точка [{userX} : {userY}] находится на пересечении плоскостей");
}