
string?[] arr = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the names");
    arr[i] = Console.ReadLine();

}

Console.WriteLine();

Console.WriteLine("Alphabetical Order:");
Array.Sort(arr);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);

}

Console.WriteLine() ;

Console.WriteLine("Reverse Order:");
Array.Reverse(arr);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);

}

Console.WriteLine();

string t = "";
Console.WriteLine("enter the string to be searched");
t = Console.ReadLine();
var flag = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == t)
    {
        flag = 1;
        break;
    }
}
if (flag == 1)
{
    Console.WriteLine("string found");
}
else { Console.WriteLine("String not found"); }

string? e = "";
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Splitted Value: ");
    e = null;
    e = arr[i];
    string[] s2 = e.Split(' ');
    foreach (var item in s2)
    {
        Console.WriteLine(item);
    }



}





int f = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < i; j++)
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



