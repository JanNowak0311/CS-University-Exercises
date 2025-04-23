int suma = 0;
string c = "";
string pierw = "";
int licznik = 0;
for (int i = 1000; i < 10000; i++)
{
    pierw = "";
    string drug = "";
    suma = 0;
    int p = 0;
    int d = 0;
    c = Convert.ToString(i);
    for (int j = 0; j < 4; j++)
    { 
        if (j < 2)
        {
            pierw += c[j];
            
        }
        if (j > 1)
        {
            drug += c[j];
        }

    }
    p = Convert.ToInt32(pierw);
    suma += (p * p);
    d = Convert.ToInt32(drug);
    suma += (d * d);
    if (suma == i)
    {
        Console.WriteLine(i);
        licznik += 1;
    }
}
Console.WriteLine("Program znalazł {0} takie liczby", licznik);
Console.ReadKey();