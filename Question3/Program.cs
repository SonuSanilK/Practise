// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n = 5;
decimal[] arr = new decimal[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the flight fares: ");
    arr[i] = Convert.ToDecimal(Console.ReadLine());

}
Console.WriteLine();

Console.WriteLine("Ascending Order:");
Array.Sort(arr);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);

}

Console.WriteLine();

Console.WriteLine("Descending Order:");
Array.Reverse(arr);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);

}

Console.WriteLine();

Console.WriteLine("Enter the fare to be searched");
Decimal search = Convert.ToDecimal(Console.ReadLine());
var result = Array.Find(arr, e => e == search);
if (result != 0)
{

    Console.WriteLine(result);

}
else

    Console.WriteLine("not found");


Array.Sort(arr);
Console.WriteLine("Maximum fare is: " + arr[n-1]);
Console.WriteLine("Minimum fare is: " + arr[0]);



int f = 0;
for(int i =0; i < arr.Length; i++)
{
    for(int j = 0; j < i; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine("Duplicate found" + arr[i]);
            f = 1;
            break;
        }
    }
  
}
if (f == 0)
    Console.WriteLine("Not found");