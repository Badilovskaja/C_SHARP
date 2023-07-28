// Напишитепрограмму которая принимает на вход три числа и проверяет может ли существовать треугольник такой длины-- нужно проверить чтобы сума двух сторон треугольника была ,большше третьей стороны --- используем bool -- правда лож

bool IsTrianglePossible(int sideA, int sideB, int sideC)
{
    if ((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB))
        return true;
    return false;
}
Console.WriteLine(IsTrianglePossible(3, 4, 5));
// .......... или вывод
// if (IsTrianglePossible(1, 4, 5))
//     Console.WriteLine("The triaggle is possible");
// else
//     Console.WriteLine("The triaggle is impossible");



// ...................другое решение
Console.WriteLine("Введите длинну первой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну второй стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну третьей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Да, может существовать");
else
    Console.WriteLine("Нет, не может существовать");