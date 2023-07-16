// Задать одномерный масив из 123 чисел, найти количество чисел от 10 до 99

// метод создает масив чисел
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


// метод поиска числа чисел от 100 до 999

int fillNumberArray(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {
            count = count + 1;
        }
    }
    return count;
}

// cоздаем новый массив который запускает функцию создания рандомного числа
int[] myArray = getRandomArray(123, 200);

// выводим массив чисел
printArray(myArray);

// cоздаем новый массив который вызывает функцию поиска чисел от 10 до 99
int result = fillNumberArray(myArray, 100, 999);

// выводим в консоль число чисел
Console.WriteLine($"Количество трехзначных чисел в массиве - {result}");

