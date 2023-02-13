// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Enter the flight fare: ");
double fare = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time:");
int time = Convert.ToInt32(Console.ReadLine());

if (time >= 6 && time < 9)
{
    fare = (fare * 0.1) + fare;
    Console.WriteLine("The flight fare is:" + fare);
}
else if (time >= 9 && time < 17)
{
    fare = (fare * 0.2) + fare;
    Console.WriteLine("The flight fare is:" + fare);


}
else if (time >= 17 && time < 23)
{
    fare = (fare * 0.07) + fare;
    Console.WriteLine("The flight fare is:" + fare);

}
else
{
    fare = (fare * 0.05) + fare;
    Console.WriteLine("The flight fare is:" + fare);

}
