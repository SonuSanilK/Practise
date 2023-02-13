using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    internal class CollegeStudent : IStudent
    {
        public string Name { get; set; }

        public string Branch { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} of branch {Branch}");
        }

        public void GetData()
        {
            Console.WriteLine("Enter the Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the branch");
            Branch = Console.ReadLine();
        }
    }
}
