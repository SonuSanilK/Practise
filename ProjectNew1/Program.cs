using ProjectNew1.Entities;
using ProjectNew1.Types;
using ProjectNew1;


StudentManagement manager = new StudentManagement();
while (true)
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Delete");
    Console.WriteLine("3. Update");
    Console.WriteLine("4. Find");
    Console.WriteLine("5. Exit");
    

    int userOption = int.Parse(Console.ReadLine());
    if (!Enum.IsDefined(typeof(Option), userOption))
    {
        Console.WriteLine("Invalid Option");
        continue;
    }

    Option option = (Option)userOption;

    switch (option)
    {
        case Option.Add:
            GetStudent(manager);

            break;
        case Option.Delete:
            break;
        case Option.Update:
            break;
        case Option.Find:
            Console.WriteLine("Enter the Register Number: ");
            string regNo = Console.ReadLine();
            
            Student s = manager.Find(regNo);
            if (s is null)
            {
                Console.WriteLine("No student found");
            }
            else
            {
                Console.WriteLine("Found: "+ s.Name);
            }
            break;
        case Option.Exit:
            break;
        default:
            break;
    }


}

static void GetStudent(StudentManagement manager)
{
    Student s = new Student();
    Console.WriteLine("Enter the Name: ");
    s.Name = Console.ReadLine();

    Console.WriteLine("Enter the Register Number");
    s.RegisterNumber = Console.ReadLine();

    manager.Add(s);
}