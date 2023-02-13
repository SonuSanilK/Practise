using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore.Entities
{
    internal class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string RegisterNumber { get; set; }

        public const string SchoolName = "AXSCSC";

        public Student(string registerNumber)
        {
            RegisterNumber= registerNumber;
        }
    }
}
