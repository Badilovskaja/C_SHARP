/*Напишите програму которая на входе принимает два числа и проверяет является ли число квадратом второго
a = 25; b = 5 - да
а = 2  b = 10 - no
a =9 b = 3 - yes
a = 3 b = 9 no
*/
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2 * number2)
//     Console.WriteLine("true");
// else
//     Console.WriteLine("false");

//............или

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
bool result = false;
if (number1 == number2 * number2) result = true;
Console.WriteLine(result);

