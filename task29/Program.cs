// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
PrintArray(array);

// ...........................or 
// int[] array = { 1, 2, 5, 7, 19 };
// Console.Write(array);
// .................or
// int[] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = new Random().Next(0, 11);
//     Console.Write(" " + Method(i) + " ");
// }
// Console.Write("]");

// int Method(int a)
// {
//     return numbers[a];
// }