//Напишите програму замены элементов масива б положительные меняем на отрицательные

//  метод создания рандомного масива
int[] FillArray(int size, int deviation)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    PrintArray(result); //сразу выводит результат
    return result;
}


// метод вывода на экран
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

// метод замены позитивных цифер на негативные

void NegToPos(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

//выводим значение массив  размер масива, число масива
int[] numArray = FillArray(15, 10);
NegToPos(numArray);
PrintArray(numArray);