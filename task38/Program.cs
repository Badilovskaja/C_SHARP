// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


//  метод создания рандомного масива
double[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);

    }
    return result;
}

// метод вывода чисел
double printArray(int[] arrayToPrint)
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



// Найдите разницу между максимальным и минимальным элементов массива.

int[] productOfPairs(int[] arr)
{
    int max = 0;
    int min = 0;
    int array = 0;//новая переменая размер масива
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



// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }
