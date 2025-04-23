int n = 101;
int sumaParz = 0;
int sumaNieParz = 0;
int[] dane = new int[n];
for (int i = 1; i < n; i++)
{
    dane[i] = i;
    //Console.WriteLine(dane[i]);
}

foreach (int i in dane)
{
    if (i % 2 == 0)
    {
        //Console.Write(i);
        sumaParz += i;

    }
    else
    {
        sumaNieParz += i;
    }

}
Console.WriteLine("Suma Parzystych: {0}", sumaParz);
Console.WriteLine("Suma Parzystych: {0}", sumaNieParz);
Console.ReadKey();
