Random rnd = new Random();
int[] tabJed = new int[100];
int[,] tabDwu = new int[10, 10];

int cykle = 0;

for (int i = 0; i < 100; i++)
{
    tabJed[i] = rnd.Next(0, 99);
    cykle += 1;
}
for (int i = 0; i < 10; i++)
    for (int j = 0; j < 10; j++)
    {
        tabDwu[i, j] = rnd.Next(0, 99);
        cykle += 1;
    }

int liczba1 = 0, liczba2 = 0;
int indeks1 = 101, indeks2 = 11, indeks22 = 11;

Console.WriteLine("Wpisz swoją liczbę");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tablica 1");
for (int i = 0; i < 100; i++)
{
    Console.Write(tabJed[i] + ", ");
    if (n == tabJed[i])
    {
        liczba1 = tabJed[i];
        indeks1 = i + 1;
    }
    cykle += 1;
}
Console.WriteLine();
if (indeks1 == 101)
    Console.WriteLine("Twojej liczby nie ma w tej tabeli");
else
    Console.WriteLine("Twoja liczba to {0}, i ma przypisany index: {1}", liczba1, indeks1);
Console.WriteLine();
Console.WriteLine("Tablica 2");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(tabDwu[i, j] + ",\t");
        if (n == tabDwu[i, j])
        {
            liczba2 = tabDwu[i, j];
            indeks2 = i + 1;
            indeks22 = j + 1;
        }
        cykle += 1;
    }
    Console.WriteLine();
}
Console.WriteLine();
if (indeks2 == 11 && indeks22 == 11)
    Console.WriteLine("Twojej liczby nie ma w tej tabeli");
else
    Console.WriteLine("Twoja liczba to {0}, i ma przypisany index: [{1}, {2}]", liczba2, indeks2, indeks22);
Console.WriteLine("Program wykonal {0} cykli", cykle);
Console.ReadKey();

