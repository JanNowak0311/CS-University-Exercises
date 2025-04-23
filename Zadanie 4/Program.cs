for (int i = 65; i < 91; i++)
{
    Console.Write(Convert.ToChar(i) + ", ");
}

int j = 90;
Console.WriteLine();
while (j > 64){
    Console.Write(Convert.ToChar(j) + ", ");
    j--;
}
Console.WriteLine();
for (int i = 90; i > 64; i--)
{
    Console.Write(Convert.ToChar(i) + ", ");
}
Console.ReadKey();
