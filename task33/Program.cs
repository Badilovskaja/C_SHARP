
//Напишите програму каторая определяет присутствие числа в масиве и выводит да нет

//  метод создания рандомного масива
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
    Console.ForegroundColor = ConsoleColor.White;
}

// число вводит пользователь
Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int[] randomArray = getRandomArray(16, 4);
printArray(randomArray);

// Булевый метод сравнения чисел в масиве с числом пользователя да---нет
bool isNumberInArray(int[] randonArray, int Number)
{
    for (int i = 0; i < randonArray.Length; i++)
    {
        if (randonArray[i] == Number)
            return true;
    }
    return false;
}
if (isNumberInArray(randomArray, Num))
    Console.WriteLine("да");
else Console.WriteLine("нет");