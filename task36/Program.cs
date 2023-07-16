// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//  метод создания рандомного масива
int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);

    }
    return result;
}

// метод вывода чисел
void printArray(int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.ForegroundColor = ConsoleColor.White;
}
// метод который находит сумму элементов, стоящих на нечётных позициях.
int sumOfNegativArray(int[] NegativArray)
{

    int sumNumbers = 0;
    int i = 0;
    while (i < NegativArray.Length)
    {
        sumNumbers = sumNumbers + NegativArray[i];
        i = i + 2;
    }
    return sumNumbers;

}
//     int sum = 0;
//     for (int i = 0; i < NegativArray.Length; i++)
//     {
//         if (NegativArray[i] % 2 == 1)
//         {
//             sum += NegativArray[i];
//         }
//     }
//     return sum;
// }
// {
//     int sumNumbers = 0;
//     int i = 0;
//     while (i < sumNegativArray.Length)
//     {
//         sumNumbers = sumNumbers + NegativArray[i];
//         i = i + 2;
//     }
//     return sumNumbers;
// }

// выводим рандомный масив и сумму

int[] array = getRandomArray(10, 20);
printArray(array);
int result = sumOfNegativArray(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в масиве равна - {result}");


