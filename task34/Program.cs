//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


//  метод создания рандомного масива
int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation +);

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



// создаем метод который Напишите программу, которая покажет количество чётных чисел в массиве. 

int[] productOfPairs(int[] arr, int number)
{
    int count = 0;//новая переменая счетчик
    for (int i = 0; i < arr.Length; i++)
    {
        if (number % 2 == 0)
        {
            //если число четное тогда
            count = count[i] + 1;
        }
    }
    return count;
}




// выводим рандомный масив

getRandomArray(10, 10);
printArray(array);
int[] prodArray = productOfPairs(array);
printArray(prodArray);