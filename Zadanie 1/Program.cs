Random rnd = new Random();
Console.WriteLine("Podaj ilość Liczb:");
int n = Convert.ToInt32(Console.ReadLine());
int maks = 0;
int min = 100;
//int Wylosowane[5];
float srednia = 0;
int a = 0;
Console.WriteLine("Wylosowane liczby to:");
for (int i = 0; i < n; i++)
{
    a = 0;
    a = rnd.Next(99);
    Console.WriteLine(a);
    
    if (a >= maks)
    {
        maks = a;
    }
    if  (a <= min)
    {
        min = a;
    }
    srednia += a;
}
//Console.WriteLine(srednia);
Console.WriteLine("Max = {0}", maks);
Console.WriteLine("Min = {0}", min);
Console.WriteLine("Średnia = {0}", srednia/n);
Console.ReadKey();