Console.WriteLine("a) While");
Console.WriteLine("Podaj liczbe do obliczenia silni");
string n = Console.ReadLine();
int silnia1 = 1;
int silnia2 = 1;
int iteracja = 0;
int b = 0;
while (iteracja < n.Length)
{
    b = n[iteracja] - '0';
    //Console.WriteLine(b);
    silnia1 *= b;
    iteracja++;
}
Console.WriteLine("Silnia z twojej liczby to {0}", silnia1);
Console.WriteLine("b) For");
for (int i = 0; i < n.Length; i++)
{
    b = n[i] - '0';
    //Console.WriteLine(b);
    silnia2 *= b;
}
Console.WriteLine("Silnia z twojej liczby to {0}", silnia2);
Console.ReadKey();



