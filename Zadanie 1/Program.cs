int x = 0,y = 0,z = 0;
Console.WriteLine("Podaj x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj y");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj z");
z = Convert.ToInt32(Console.ReadLine());
int c = ((x * x) + (y * y));
Console.WriteLine();
if ((x * x) + (y * y) == (z * z))
{
    Console.WriteLine("Trojka pitagorejska");
     
}
else
{
    Console.WriteLine("Nie Trojka pitagorejska");

}
Console.ReadKey();