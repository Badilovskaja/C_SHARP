Console.WriteLine("ВВедите число");
int Num1 = Convert.ToInt32(Console.ReadLine());
if (Num1 % 7 == 0 && Num1 % 23 == 0)
{
    Console.WriteLine($" Число {Num1} кратно 7 и 23");
}
else
{
    Console.WriteLine($" Число {Num1} не кратно 7 и 23");
}