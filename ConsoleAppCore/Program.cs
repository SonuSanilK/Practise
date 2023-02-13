//Console.WriteLine("Enter the first name");
//string? FirstName = Console.ReadLine();

//Console.WriteLine("Enter the last name");
//string? LastName = Console.ReadLine();

//Console.WriteLine("Your full name is:");
//Console.WriteLine(FirstName + " " + LastName);

//const int c = 10;
//c = 11; we cannot change the value when it is written in const
//Console.WriteLine();

//string s = "Hello World";
////Console.WriteLine(s[0]);
//Console.WriteLine(s.Length);

//Console.Beep(); \\ to get beep sound
//Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Red;
//string s = "Hello";
//Console.WriteLine(s);


//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(2000); // to lag the output
//}

//var data = "Hello World";
//for (var i = 0; i < data.Length; i++)
//{
//    Console.WriteLine(data[i]);
//}

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}


//string ns = "50";
//int i = int.Parse(ns);it will provide error if null value is inserted but
//if we use (int i = Convert.ToInt32(ns)) if we write null value then it will print 0
//Console.WriteLine( i);
//Console.WriteLine( i.GetType());  // to get the datattype of the value

//string s = "   Hello    ";
//Console.WriteLine(s.Trim());  // trim will remove the spaces in the string there are trim start and trim end

//string s = "  Hello ";
//int count = 0;
//foreach (char c in s)
//{
//    if (c == ' ')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
//Console.WriteLine(s.Count(m => m.Equals(' ')));


//string s = "This is text";
//var res = s.Contains("Text", StringComparison.InvariantCultureIgnoreCase);

//if (res)
//    Console.WriteLine("Yes");
//else
//    Console.WriteLine("No");

//int i = 10;
//int j= 11;

//uint ui = 10;
//uint ui2 = -11;  // in uint we cannot use negative values we can only use positive values.

// for declaring an array
//int[] arr = new int[2];
//var arr1 = new int[2];

//int[] arr2 = { 1, 2, 3 };
//int[] arr4 = new int[] { 1, 2, 3 };
//int[] arr5 = new int[3] {1,2, 3 };

//string s = "This is a string";

//Console.WriteLine(s.IndexOf('i')); // this is used find the index of i
//Console.WriteLine(s.IndexOf("i"));
//Console.WriteLine(s.LastIndexOf('i'));

//string s = "This is  a string";
//if (s.Contains("is")) // to find whether it is present or not
//{
//    Console.WriteLine("Found");
//}
//else
//{
//    Console.WriteLine("not found");
//}


//string s = "This is  a string";

//s = s.Replace(" ", "");     // to replace words
//Console.WriteLine(s);

//string s = "This is  a string";

//s = s.Remove(0, 5);    // remove is used to remove the words from 0 to 5
//Console.WriteLine(s);




//char?[] arr = { 'a', 'b', 'c', 'a', 'h' };

//string s = string.Empty;
//foreach(char c in arr)
//{
//    if(!s.Contains(c))
//        s += c;
//}

//Console.WriteLine(s);  // convert characters into string from character array which does not contain duplicates.


//string firstName = "John";
//string lastName = "Cena";
//int age = 10;

//string result = firstName+ " " + lastName;
//string res = firstName+ " " + lastName +" is " + age + " years old ";
//string res1 = $"{firstName} {lastName} is {age} years old";

//string res2 = string.Format("{0} {1} is {2} years old", firstName, lastName, age);

//Console.WriteLine(result);
//Console.WriteLine(res1);
//Console.WriteLine(res);
//Console.WriteLine(res2);

//string firstName = "John";
//string lastName = "Cena";

//string res = string.Join(" ", firstName,lastName);
//string res1 = string.Concat(firstName, " ", lastName);
//Console.WriteLine(res1);
//Console.WriteLine(res);



//string s = "This is A StRinG";
//string res = " ";

//foreach (var c in s)
//{
//    res += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);

//or


//    if (char.IsUpper(c))
//    {
//        res = res + c.ToString().ToLower();
//    }
//    else
//    {
//        res = res + c.ToString().ToUpper();
//    }
//}

//or

//    if (c >= 'a' && c <= 'z')
//        res += char.ToUpper(c);
//    else
//        res += char.ToLower(c);
//}
//Console.WriteLine(res);


// Object


//object o = 5;
//object o = "Hello";

//string s = (string)o;                         // type casting
//Console.WriteLine(s.ToUpper());

//dynamic

//dynamic o = "Hello";
//Console.WriteLine(o.ToUpper());


//object[] data = { 1, 2, 3, "Four", "Five" };

//int sum = 0;
//foreach(object item in data)
//{
//    var type = item.GetType();
//    if(type == typeof(int))
//    {
//        sum += (int)item;
//    }
//}
//Console.WriteLine(sum);


//------------------------LIst----------------------------

//var lst = new List<int>() { 4,5};    // we can add elements in a list by using {}
//lst.Add(1);
//lst.Add(2);
//lst.Add(3);

//Console.WriteLine(lst[1]);       // it will provide the element in the list.
//Console.WriteLine(lst.Count); // count will provide the number of elements in the list.

//foreach(var item in lst)
//{
//    Console.WriteLine(item);
//}


//var lst1 = new List<int> { 1,2,3};
//var lst2 = new List<int> { 4, 5, 6 };

//lst1.AddRange(lst2);    // To combine 2 list.

//foreach(var item in lst1)
//{
//    Console.WriteLine(item);
//}


//var lst1 = new List<int> { 1, 2, 3 };

//lst1.Remove(1);      // It is used to remove the value, here we will not provide index we provide the value
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}


//var lst1 = new List<int> { 1, 2, 3 };

//lst1.RemoveAt(1);      // It is used to remove the value, here we will provide index and not provide the value
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}

//var lst1 = new List<int> { 1, 2, 3 };

//lst1.RemoveRange(0, 2);   // It is used to remove the value, here we will provide range not the value.
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}

//var lst1 = new List<int> { 1, 2, 3 };

//lst1.Clear();                 // used to remove the list.
//foreach (var item in lst1)
//{
//    Console.WriteLine(item);
//}


//------- Dictionary-------

//var person = new Dictionary<string, string>();

//person.Add("name", "Adarsh");        // used to insert values in dictionary.
//person.Add("Age", "25");
//person["name"] = "Test";             // we can add data by using this if thee is no variable it will add and if the variable is same it will replace.

//Console.WriteLine(person["name"]);   // used to print name


//var person = new Dictionary <string, string>()
//{
//    {"Name", "John" },
//    {"Age", "21" }
//};

//foreach(var item in person)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

//var students = new List<Dictionary<string, object>>();

//while(true)
//{
//    Console.WriteLine("1. Add Students.");
//    Console.WriteLine("2. View Student");

//    var input = Console.ReadLine();
//    switch(input)
//    {
//        case "1":

//            Console.WriteLine("Enter Student Name: ");
//            var name = Console.ReadLine();

//            Console.WriteLine("Enter Student Mark1: ");
//            var mark1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Student Mark2: ");
//            var mark2 = int.Parse(Console.ReadLine());


//            var student = new Dictionary<string, object>()
//            {
//                { "Name" , name},
//                { "Mark1" , mark1},
//                { "Mark2" , mark2}
//            };
//            students.Add(student);
//            break;

//        case "2":
//            foreach(var item in students)
//            {
//                int m1 = (int)item["Mark1"];
//                int m2 = (int)item["Mark2"];
//                int total = m1+ m2;
//                Console.WriteLine($"Name: {item["Name"]} | Total: {total}");
//            }
//            break;
//        default:
//            break;
//    }
//}


//var d = new List<Dictionary<string, object>>();
//d.Add(key, value); // or   (to collect value from the user
//d[Key] = value

//stud.Add(new Dictionary<string, object>()
//{
//    {"Name", "John" },
//    {"Age", 18 },
//    {"CGPA", 3.5 }
//});


// --------------------Object Oriented ----------

//var p = new Person();

//p.Name = "John ";
//p.Age = 30;

//var p1 = new Person();
//p1.Name = "Jane";
//p1.Age= 1;


//class Person
//{
//    public string? Name;
//    public int Age;

//    public void Display()
//}


//var d = new Dictionary<string, string>()
//{
//    {"key1", "value1" },
//    {"key2", "value2" }
//};

//Console.WriteLine("Enter a key to search");
//var key = Console.ReadLine();

//foreach(var item in d)
//{
//    if(item.Key == key)
//    {
//        Console.WriteLine("Found: " + item.Value);
//        break;
//    }
//}

///////// ---------- to seperate the numbers------------

//using System.Globalization;

//Console.WriteLine("Enter the string");
//string text = Console.ReadLine();
//int[] numbers;
//int count = 0;
//foreach( char item in text)
//{
//    if (item >= '0' && item <= '9')
//    {
//        count++;
//    }
//}
//numbers = new int[count];
//int index = 0;
//foreach (char item in text)
//{
//    if (item >= '0' && item <= '9')
//    {
//        numbers[index++] = int.Parse(item.ToString());
//    }
//}
//Console.WriteLine(string.Join(",", numbers));


//------------------------------Class--------------

//using ConsoleAppCore;

//var emp = new Employee();
//{
//    emp.Name = "Test";
//    emp.Age = 30;
//}
//Console.WriteLine(emp.Age);

//using ConsoleAppCore;
//using System.Security.Cryptography.X509Certificates;

//var m1 = new Mark()
//{
//    ExamName = "Sonu",
//    Subject = "Maths",
//    MarkScored = 250,
//    MaxMark = 300
//};

//var m2 = new Student()
//{
//    Name = "Arun",

//};
//m2.NewList.Add(m1);




//   Insert an employee name and email using list and dictionary


//var employees = new List<Dictionary<string, string>>();


//while (true)
//{
//    Console.WriteLine("1. Enter employee details");
//    Console.WriteLine("2. View employee details");
//    Console.WriteLine("3. Exit");



//    string? input = Console.ReadLine();



//    switch (input)
//    {
//        case "1":
//            AddEmployee();
//            break;



//        case "2":
//            DisplayEmployees();
//            break;

//        case "3":
//            Environment.Exit(0);
//            break;

//        default:
//            Console.WriteLine("Invalid Option.");
//            break;
//    }



//    void AddEmployee()
//    {
//        var employee = new Dictionary<string, string>();



//        Console.WriteLine("Enter the employee name: ");
//        employee["Name"] = Console.ReadLine();



//        Console.WriteLine("Enter th employee email: ");
//        employee["Email"] = Console.ReadLine();



//        employees.Add(employee);



//    }



//    void DisplayEmployees()
//    {
//        foreach (var item in employees)
//        {
//            Console.WriteLine(item["Name"]);
//            Console.WriteLine(item["Email"]);
//        }
//    }
//}



//using ConsoleAppCore;
//using System.ComponentModel.DataAnnotations;

//var emp = new Employeeee()
//{
//    Name = "Emp1",
//    Email = "emp@gmail.com"
//};

//Console.WriteLine(emp);

//using ConsoleAppCore;

//Console.WriteLine("Enter the number of employees");
//int size = int.Parse(Console.ReadLine());

//Emp[] e = new Emp[size];
//int[] emp1 = new int[size];

//for (int i = 0; i < size; i++)
//{
//    e[i] = new Emp();
//}

//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine("enter the name of employee");
//    e[i].Name = Console.ReadLine();
//    Console.WriteLine("Enter the salary");
//    e[i].Salary = int.Parse(Console.ReadLine());
//}


//using ConsoleAppCore.Entities;

//var s = new Student("ADXA");
//s.Name = "Sonu";
//s.Age = 30;

//Console.WriteLine(s.Name);
//Console.WriteLine(s.Age);
//Console.WriteLine(s.RegisterNumber);
//Console.WriteLine(Student.SchoolName); // Constant string in a class can be called by using classname.name and also we can directly call the data without declaring object

// In class if we use constants we cannot change at any time but in read only we can change the value once.
//So we can change the value once from read only.It can change only from comnstructor.

//string ConvertCasing(string text, Options option)
//{
//    switch (option)
//    {
//        case Options.UpperCase:
//          return text.ToUpper();
//        case Options.LowerCase:
//            return text.ToLower();
//        default:
//            return text;
//    }
//}


//var res = ConvertCasing("Hello World", Options.UpperCase);


//    enum Options
//{
//    UpperCase,
//    LowerCase,
//}


//using ConsoleAppCore;

//try
//{
//	Console.WriteLine("Enter number 1: ");
//	int num1 = int.Parse(Console.ReadLine());

//	Console.WriteLine("Enter number 2: ");
//	int num2 = int.Parse(Console.ReadLine());

//	if(num2 == 0)
//	{
//		throw new RangeException("My message");
//	}
//	Console.WriteLine(num1 + num2);
//	Console.WriteLine(num1 - num2);
//	Console.WriteLine(num1 * num2);
//    Console.WriteLine(num1 / num2);
//}
////catch(DivideByZeroException)
////{
////	Console.WriteLine("Second number should not be zero");
////}
//catch(Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}


//IStudent st = new SchoolStudent();
//st.Display();


//interface IStudent
//{
//    public void Display();

//}

//class SchoolStudent : IStudent
//{
//    public string Name { get; set; }
//    public void Display() => Console.WriteLine(Name);
//}


