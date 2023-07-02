// Console.WriteLine("ВВедите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = -number; i <= number; i++)
// {
//     Console.WriteLine(i);
// }


// .................или


Console.WriteLine("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while (count <= number)
{
    Console.Write(count);
    Console.Write(" ");
    count++;
}


