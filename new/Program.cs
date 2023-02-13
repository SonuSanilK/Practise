// See https://aka.ms/new-console-template for more information
using ConsoleAppCore;
Console.WriteLine("Enter the number of employees");
int size = int.Parse(Console.ReadLine());

Emp[] e = new Emp[size];
int[] emp1 = new int[size];

for (int i = 0;i < size; i++)
{
    e[i] = new Emp();
}

for(int i = 0;i < size;i++)
{
    Console.WriteLine("enter the name of employee");
    e[i].Name
}