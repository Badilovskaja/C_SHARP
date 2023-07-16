//напишите произведение пары чисел в одномерном масивеб посчитать первое и последнее и суму вывести в новый масив


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



// создаем метод который проверяет масив четный или нет если нет добавляет 1, и берет первое и последнее число и умножает их друг на друга

int[] productOfPairs(int[] arr)
{
    int size;//новая переменая размер масива
    if (arr.Length % 2 == 0) //если длина масива четная тогда
    {
        size = arr.Length / 2; // идем от 0 до середины масива
    }
    else

        // делаем масив четным
        size = arr.Length / 2 + 1;
    //новый масив = размеру масива
    int[] productArr = new int[size];

    for (int i = 0; i < arr.Length; i++)

        productArr[i] = arr[i] * arr[arr.Length - 1 - i];

    if (size % 2 == 1)

        productArr[size - 1] = arr[arr.Length / 2];
    return productArr;

}
// выводим рандомный масив

int[] array = getRandomArray(10, 10);
printArray(array);
int[] prodArray = productOfPairs(array);
printArray(prodArray);