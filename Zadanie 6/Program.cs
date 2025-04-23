Random rnd = new Random();
int[] tabJed = new int[100];
int[,] tabDwu = new int[10, 10];

for (int i = 0; i < 100; i++)
    tabJed[i] = rnd.Next(0, 99);

for (int i = 0; i < 10; i++)
    for (int j = 0; j < 10; j++)
        tabDwu[i, j] = rnd.Next(0, 99);

int maks1 = 0, min1 = 100, maks2 = 0, min2 = 100, indeks1Max = 101, indeks1Min = 101;
int ind2max1 = 101, ind2max2 = 101, ind2min1 = 101, ind2min2 = 101;
Console.WriteLine("Tablica 1");
for (int i = 0; i < 100; i++)
{
    Console.Write(tabJed[i] + ", ");
    if (tabJed[i] >= maks1)
    {
        maks1 = tabJed[i];
        indeks1Max = i + 1;
    }
    if (tabJed[i] <= min1)
    {
        min1 = tabJed[i];
        indeks1Min = i + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Tablica 2");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(tabDwu[i, j] + ",\t");
        if (tabDwu[i, j] >= maks2)
        {
            maks2 = tabDwu[i, j];
            ind2max1 = i + 1;
            ind2max2 = j + 1;
        }
        if (tabDwu[i, j] <= min2)
        {
            min2 = tabDwu[i, j];
            ind2min1 = i + 1;
            ind2min2 = j + 1;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Max Jednowymiarowej: = {0}", maks1); Console.Write(" Index: = {0}", indeks1Max);
Console.WriteLine();
Console.Write("Min Jednowymiarowej: = {0}", min1); Console.Write(" Index: = {0}", indeks1Min);
Console.WriteLine();
Console.Write("Max Dwuwymiarowej: = {0}", maks2); Console.Write(" Index: = {0}, {1}", ind2max1, ind2max2);
Console.WriteLine();
Console.Write("Min Dwuwymiarowej: = {0}", min2); Console.Write(" Index: = {0}, {1}", ind2min1, ind2min2);
Console.ReadKey();
