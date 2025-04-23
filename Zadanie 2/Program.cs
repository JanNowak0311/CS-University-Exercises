int n = 10;
int[,] macierz = new int[n, n];
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        macierz[i, j] = i;
int wynik = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write("{0} ", macierz[i, j]);
            wynik += macierz[i, j];
            
        }
        else
        {
            Console.Write("{0} ", 0);
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Suma wynosi {0}", wynik);

Console.ReadKey();
