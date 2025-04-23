int x = 1;

for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {

        Console.Write(x * j + "\t");
    }
    Console.WriteLine();
    x++;
}
Console.ReadKey();