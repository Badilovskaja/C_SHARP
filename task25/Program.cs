// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16


int numMult(int numFirst, int numSecond)
{

    int count = 1;
    for (int i = 1; i <= numSecond; i++)
    {
        count = count * numFirst;
    }
    return count;
}
Console.Write("Введите первое число: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numY = Convert.ToInt32(Console.ReadLine());

int result = numMult(numX, numY);
Console.WriteLine(result);
