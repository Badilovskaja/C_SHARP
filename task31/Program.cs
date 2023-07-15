// задайте массив из 12 элементов заполненых случайными числами (-9, 9) найдите суму отрицательных и положительных чисел

// метод создает масив чисел
int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);

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
    Console.WriteLine("---------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}


// метод суммы элементов
int sumElementOfArray(int[] arrayToCalculate, int multiply)
{
    int result = 0;
    for (int i = 0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] * multiply > 0)
        {
            result += arrayToCalculate[i];
        }
    }
    return result;
}

int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);
Console.WriteLine();


int positiveSumOfArray = sumElementOfArray(randomArray, 1);
int negativeSumOfArray = sumElementOfArray(randomArray, -1);
Console.WriteLine($"Сумма положительных чисел в масиве {positiveSumOfArray} сумма отрицательных чисел {negativeSumOfArray}");