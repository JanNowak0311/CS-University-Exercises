int n = 10;
int[,] macierz = new int[n, n];
int kolumna1 = 0;
int kolumna2 = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j == 0)
        {
            Console.Write("{0}   ", i);
            kolumna1 += i;
        }
        if (j == 0)
        {
            Console.Write("{0}   ", i * i);
            kolumna2 += i*i;

        }
        else
        {
            Console.Write("{0}    ", 0);
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Suma 1 kolumny wynosi {0}", kolumna1);
Console.WriteLine("Suma 2 kolumny wynosi {0}", kolumna2);
Console.ReadKey();

