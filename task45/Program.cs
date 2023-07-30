// 45 Напишите программу которая будет создавать копию заданого одномерного масива с помощью поэлементного копирования --- через цикл for будем назначать каждый элемент масива - копировать тем что будем присваивать номер из предыдущего масива



// метод копирования
int[] copyArr(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
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
int[] test = { 1, 2, 3, 4, 5, 6, };
printArray(test);
int[] testCopy = copyArr(test);
printArray(testCopy);

//добавить число 10 в масив

// int[] copy = test;
// test[0] = 10;
// printArray(test);
// printArray(copy);

