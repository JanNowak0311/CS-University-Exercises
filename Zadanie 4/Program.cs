string c = "";
int b = 0;
int suma = 0;
Console.WriteLine("Wszystkie trzycyfrowe liczby których suma sześcianów poszczególnych cyfr jest równa danej liczbie to: ");
for (int i = 100; i < 1000; i++)
{
    //Console.WriteLine(i);
    suma = 0;
    for (int j = 0; j < 3; j++)
    {
        c = Convert.ToString(i);
        b = c[j] - '0';
        //Console.WriteLine(b);
        suma += (b * b * b);
    }
    if (suma == i)
    {
        Console.WriteLine(i);
    }
}
Console.ReadKey();﻿
