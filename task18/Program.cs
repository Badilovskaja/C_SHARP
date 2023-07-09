// Програма по заданому номеру четверти показывает диапазон возможных координат в этой четверти(x y) 

// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());

// void GetQuarter(int quarter)
// {
//     if (quarter == 1)
//     {
//         Console.WriteLine("X > 0 && Y > 0");
//     }
//     else if (quarter == 2)
//     {
//         Console.WriteLine("X < 0 && Y > 0");
//     }
//     else if (quarter == 3)
//     {
//         Console.WriteLine("X < 0 && Y < 0");
//     }
//     else if (quarter == 4)
//     {
//         Console.WriteLine("X > 0 && Y < 0");
//     }
// }
// GetQuarter(number);



// ..........или
string QuadrantRange(int quadrant)
{
    if (quadrant == 1) return "x > 0 : y > 0";
    else if (quadrant == 2) return "x < 0 : y > 0";
    else if (quadrant == 3) return "x < 0 : y < 0";
    else if (quadrant == 4) return "x > 0 : y < 0";
    else return "invalid quadrant";
}
Console.Write("Введите число квадранта: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuadrantRange(quarter));
