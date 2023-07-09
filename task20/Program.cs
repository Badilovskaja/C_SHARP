// Поставить две точки в плоскости и узнать растояние между ними
Console.WriteLine("Enter X for first point");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y for first point");
int aY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X for second point");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y for second point");
int bY = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;
double distance = Math.Sqrt(a * a + b * b);
Console.WriteLine(distance);
