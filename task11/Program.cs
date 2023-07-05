int numberRanndom = new Random().Next(100, 1000);

int numberTwo = numberRanndom % 10;
int numberThree = numberRanndom / 100;

int result = numberThree * 10 + numberTwo;

Console.WriteLine(numberRanndom);
Console.WriteLine(result);
