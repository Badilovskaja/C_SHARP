//39 Напишите программу которая перевернет масив последнее число поставит вперед, 1 -будет последним и тд.

// ///................метод создания массива
int[] GenerateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;

}
// .............метод печати масива
void printArray(int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

// .............метод возвращающего массива
int[] reversArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}



// вывод методов
Console.Clear();
int[] numbers = GenerateArray(10, -100, 100);
printArray(numbers, "Начальный");
int[] revArray = reversArray(numbers);
printArray(revArray, "перевернытый");
