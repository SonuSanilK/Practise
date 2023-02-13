// See https://aka.ms/new-console-template for more information
DateTime[] dateofbirth = new DateTime[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the date of birth : yyyy-mm-dd ", dateofbirth);
    dateofbirth[i] = DateTime.Parse(Console.ReadLine());
   
}
   
DateTime today = DateTime.Now;

foreach (var item in dateofbirth)
{
    if ((today.Year - item.Year <= 10))
    {
        Console.WriteLine("Kid");
    }
    else if ((today.Year - item.Year > 10) && (today.Year - item.Year <= 30))
    {
        Console.WriteLine("Youth");

    }
    else if ((today.Year - item.Year > 30) && (today.Year - item.Year <= 60))
    {
        Console.WriteLine("Adult");
    }
    else
    {
        Console.WriteLine("Older");
    }
}

