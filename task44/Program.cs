// 44 написать програму которая принимает число N и проверяет является ли это число числом Фибоначи, первые числа  0 1


Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 1;
int fibi = 0;
Console.Write(number1 + " ");
Console.Write(number2 + " ");
for (int i = 2; i < number; i++)
{
    fibi = number1 + number2;
    Console.Write(fibi + " ");
    number1 = number2;
    number2 = fibi;
}

// .........................или
// ///метод выводит массив чисел фибоначи размера n
int[] Fibonacci(int n)// возвращает фибоначчи и печатает 
{
    int[] fib = new int[n];//создаем новый масив из интереджей размером n
    fib[0] = 0;// первому числу присваиваем значение 0
    if (n > 1)//  если n буде больше 1 то
    {
        fib[1] = 1;//то второе значение присваоваем 1
        for (int i = 2; i < n; i++)// запускаем цикл i от второго числа до тех пор пока не достигнем размера n
            fib[i] = fib[i - 1] + fib[i - 2]; fib[i] //она изначально будет равна 0 и ей присваеваем значение предыдущего и позапредыдущего часла
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.WriteLine($"{array[i]}");
        else
            Console.WriteLine($"{array[i]}, ");
    }
    Console.Write("]");

}
int[] fibonacci = Fibonacci(9);