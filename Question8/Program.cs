// See https://aka.ms/new-console-template for more information
using System.Transactions;

decimal[] fare = new decimal[5]; 

string?[] destination = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the destination");
    destination[i] = Console.ReadLine();

}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the fare");
    fare[i] = Convert.ToDecimal(Console.ReadLine());

}


Console.WriteLine("Enter the nth number to display destination and fare ");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 5)
{
    Console.WriteLine("Enter valid number");
}
else
{
    Console.WriteLine(("Destination : " + destination[n-1] , "Fare :" + fare[n-1]));
}























