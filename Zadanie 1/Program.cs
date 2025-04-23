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
double z = ((c - b) / a);
Console.WriteLine("x = {0}", z);
Console.ReadKey();

