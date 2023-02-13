// See https://aka.ms/new-console-template for more information


using ProjectNew;
using ProjectNew.Entities;
using ProjectNew.Types;


var manager = new StudentManager();
while (true)
{
    Console.WriteLine($"1. Add");
    Console.WriteLine($"2. Update");
    Console.WriteLine($"3. Delete");
    Console.WriteLine($"4. Find");

    int userOption = int.Parse(Console.ReadLine());
    if(!Enum.IsDefined(typeof(Option), userOption))
    {
        Console.WriteLine("Invalid Option");
        continue;
    }
    

    Option option = (Option)userOption;
    switch (option)
    {
        case Option.Add:
            var s = GetStudentData();
            manager.Add(s);
            break;
        case Option.Update:
            var student = GetStudentData();
            manager.Update(student);
            break;
        case Option.Delete:
            Console.WriteLine("Enter Register Number : ");
            string regNo = Console.ReadLine();
            manager.Delete(regNo);
            break;
        case Option.Find:
            FindStudent();

            break;
        default:
            break;
    }
}

Student GetStudentData()
{
    var student = new Student();

    Console.WriteLine("Enter the Name: ");
    student.Name = Console.ReadLine();

    Console.WriteLine("Enter the Register Number: ");
    student.RegisterNumber = Console.ReadLine();

    return student;

}

void  FindStudent()
{
    Console.WriteLine("Enter Register Number: ");
    string regNo = Console.ReadLine();
    Student student = manager.FindOne(regNo);
    if (student is null)
    {
        Console.WriteLine("No Students are Found");
        return;

    }

    Console.WriteLine("Student Found");
    Console.WriteLine($"Name: {student.Name}");
}