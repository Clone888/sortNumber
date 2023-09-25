using System.Runtime.CompilerServices;

string[] listnumbers = File.ReadAllLines("../../../Numbers.txt");

Console.WriteLine("Original order:");
int temp;
foreach (string line in listnumbers)
{
    Console.Write(line + ",");

    while (int.TryParse(line, out int num))
    {
       
    }
  

}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sorted order:");




foreach (var item in listnumbers)
{
    Console.Write(item);
}
