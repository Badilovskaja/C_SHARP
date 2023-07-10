// Напишите прогу которая выводит массив из 8 элементов заполненый  0 i 1
// 1.... пишем функцию которая выводит масив
// 2......создаем масив из рандомногочисла 0 и 1


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
    array[i] = new Random().Next(2);
}
PrintArray(array);