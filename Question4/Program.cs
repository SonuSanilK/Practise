// See https://aka.ms/new-console-template for more information

DateTime dateofbirth = new DateTime();
Console.WriteLine("Enter the date of birth : yyyy-mm-dd ", dateofbirth);
DateTime.TryParse(Console.ReadLine(), out dateofbirth);
DateTime now = DateTime.Now;
TimeSpan time = now.Subtract(dateofbirth);
//Console.WriteLine(time);
//double Hours = time.TotalHours;
Console.WriteLine("Hours Lived :" + time.TotalHours);
double days = time.Days;
Console.WriteLine("Days Lived :" + days);
double weeks = days / 7;
Console.WriteLine("Weeks Lived :" + weeks);
double months = days / 30;
Console.WriteLine("Months Lived :" + months);
double years = days / 365;
Console.WriteLine("Years Lived :" + years);

if((dateofbirth.Year) % 4 == 0)
{
    Console.WriteLine("It is a leap year");
}
else
{
    Console.WriteLine("It is not a leap year");
}


//Console.WriteLine(now);