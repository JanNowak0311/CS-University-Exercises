Console.WriteLine("Ile chcesz kolumn");
int n = Convert.ToInt32(Console.ReadLine());
int[] wiersze = new int[n];


for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ile chcesz w wierszu {0}", i + 1);
    int czy10 = Convert.ToInt32(Console.ReadLine());
    wiersze[i] = czy10;
}
int c = 0;
int d = 0;
for (int i = 0; i < n; i++)
{
    d = c;
    Console.Write("tablica [{0}] = ", i + 1);
    for (int j = 0; j < wiersze[i]; j++)
    {
        Console.Write("[{0}]", c + 1);
        c++;
    }
    Console.WriteLine();
}
Console.ReadKey();