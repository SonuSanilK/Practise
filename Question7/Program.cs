// See https://aka.ms/new-console-template for more information
string? name = "";
double miles = 0;

Console.WriteLine("Enter the name");
name = Console.ReadLine();

Console.WriteLine("Enter the miles travelled");
miles = Convert.ToDouble(Console.ReadLine());


if(miles > 10000 && miles < 20000)
{
    Console.WriteLine("10 frequent flyer points awarded");
}
else if (miles > 20000 && miles < 50000)
{
    Console.WriteLine("20 frequent flyer points awarded");
}
else if (miles > 50000 && miles < 100000)
{
    Console.WriteLine("30 frequent flyer points awarded");
}
else if (miles > 100000)
{
    Console.WriteLine("50 frequent flyer points awarded");
}
else
{
    Console.WriteLine("No points");
}
