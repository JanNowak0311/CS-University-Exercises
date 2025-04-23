using System;

Random rnd = new Random();
int i = 0;
int a = 0;
int poczatek = 0;
int koniec = 10;
int wylosowana = rnd.Next(poczatek, koniec);

while (i == 0)
{
    Console.WriteLine("Podaj liczbe:");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == wylosowana)
    {
        Console.WriteLine("Zgadles");
        break;

    }
    Console.WriteLine("Sprobuj jeszcze raz");

}
Console.WriteLine(wylosowana);
Console.ReadKey();