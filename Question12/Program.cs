// See https://aka.ms/new-console-template for more information
using System.Data;

string?[] passenger = new string[10];

string?[] destination = new string[5];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter the passenger name");
    passenger[i] = Console.ReadLine();

}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the destination");
    destination[i] = Console.ReadLine();

}

Console.WriteLine("Merge");



int j = 5;



for (int i = 0; i < 5; i++)
{
    passenger[j] = destination[i];
    j++;
}
Console.WriteLine("Array after merging: ");



foreach (var item in passenger)
{
    Console.WriteLine(item);
}







































