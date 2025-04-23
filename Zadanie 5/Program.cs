int n = 10;
int[,] macierz1 = new int[n, n];
int[,] macierz2 = new int[n, n];
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        macierz1[i, j] = 4;
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        macierz2[i, j] = 6;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(macierz1[i, j]);
        
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(macierz2[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(macierz2[i, j] + macierz1[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey();