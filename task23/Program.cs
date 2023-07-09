// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int mult = 0;
if (Num > 0)
{
    while (count < Num + 1)
    {
        mult = count * count * count;
        count++;
        Console.Write($"{mult}, ");
    }
}
else
{
    count = count * (-1);
    while (count > Num - 1)
    {
        mult = count * count * count;
        count++;
        Console.Write($"{mult}, ");
    }
}



// Console.WriteLine("Введите число: ");
// int cNum = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cNum)
// {
//     int counter = 0;
//     int length = cNum.Length;
//     while (counter < length)
//     {
//         cNum[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//         counter++;
//     }
// }

// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     while (index < count)
//     {
//         Console.Write(coll[index] + " ");
//         index++;
//     }
// }

// int[] arry = new int[cNum + 1];
// Cube(arry);
// PrintArry(arry);
