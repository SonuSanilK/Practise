//using Interface.Entities;

//var students = new List<IStudent>();
//while (true)
//{
//    Console.WriteLine("1. Add School Student");
//    Console.WriteLine("2. Add College Student");
//    Console.WriteLine("3. Display Students");

//    int option = int.Parse(Console.ReadLine());
//    switch (option)
//    {
//        case 1:
//            var ss = new SchoolStudent();
//            ss.GetData();
//            students.Add(ss);
//            break;
//        case 2:
//            var cs = new CollegeStudent();
//            cs.GetData();
//            students.Add(cs);
//            break;
//        case 3:
//            foreach (var student in students)
//            {
//                student.Display();
//            }
//            break;

//        default:
//            break;
//    }
//}





//void Total(IEnumerable<int> numbers)
//{
//    Console.WriteLine(numbers.Sum());
//}
//Total(new int[] { 1, 2,3 });
//Total(new List<int> { 1, 2,3 });


var p1 = new Person<int>();
p1.Age = 20;

var p2 = new Person<double>();
p2.Age = 20.5;

class Person<T>
{
    public string Name { get; set; }
    public T Age { get; set; }
}