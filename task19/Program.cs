// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void Polindrome(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"{number} число палиндром.");
    }
    else Console.WriteLine($"{number}  не палиндром.");
}

if (number!.Length == 5)
{
    Polindrome(number);
}
else Console.WriteLine($"Повторите ввод");

// Console.WriteLine("Введите пятизначное число: ");
// int numExam = Convert.ToInt16(Console.ReadLine());

// int Polindrome(int p)
// {
//     int count = 0;
//     int polindrome = p.length() - 1;
//     while (count < polindrome)
//     {
//         if (polindrome[count] != polindrome[polindrome])
//         {
//             return false;
//         }
//         count++;
//         polindrome--;
//     }
//     return true;
// }
// int newNumPol = Polindrome(numExam);




