// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the no odd numbers");
int odd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the no even numbers");
int even = Convert.ToInt32(Console.ReadLine());

int n = odd + even;

odd = 0;
even = 1;

decimal fare = 0;

decimal[] price = new decimal[n];
Console.WriteLine("Enter the fare: ");
for (int i = 0; i < n; i++)
{
    fare = Convert.ToDecimal(Console.ReadLine());
    if (fare % 2 == 0)
    {
        price[even] = fare;
        even += 2;
    }
    else
    {
        price[odd] = fare;
        odd += 2;
    }
}

Console.WriteLine("Entered fares : ");
foreach (int i in price)
{
    Console.WriteLine(i);
}