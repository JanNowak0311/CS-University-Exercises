using System;
int x = 0;
int i = 0;
double a = 0;
while (i == 0)
{
    Console.WriteLine("Podaj liczbe a:");
    a = Convert.ToDouble(Console.ReadLine());
    if (a != 0)
    {

        break;


    }
    Console.WriteLine("a = 0");

}
Console.WriteLine("Podaj liczbe b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj liczbe c:");
double c = Convert.ToDouble(Console.ReadLine());
double z = 0;
double y = 0;
double delta = (b*b) - (4 * (a * c));
if (delta < 0)
{
    x = 1;
}
if (delta == 0)
        {
    x = 2;
}
if (delta > 0)
{
    x = 3;
}
Console.WriteLine(x);
switch (x)
{
    case 1:
        Console.WriteLine("Delta = {0}", delta);
        break;
    case 2:
        Console.WriteLine("Delta = {0}", delta);
        z = (-b / (a*2));
        Console.WriteLine("x0 = {0}", z);
        break;
    case 3:
        Console.WriteLine("Delta = {0}", delta);
        z = ((-b + Math.Sqrt(delta)) / (a * 2));
        y = ((-b - Math.Sqrt(delta)) / (a * 2));
        Console.WriteLine("x1 = {0}", z);
        Console.WriteLine("x2 = {0}", c);
        break;
}

Console.ReadKey();


