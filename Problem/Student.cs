using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Student
    {
        public string Name { get; set; }
        public string RegisterNumber { get; }

        public static string School { get; set; }

        static Student()
        {
            School = "New School";
        }

        //public Student(string registerNumber)
        //{
        //    RegisterNumber = registerNumber;
        //}

        //public Student(string registerNumber,string name)
        //{
        //    RegisterNumber = registerNumber;
        //    Name = name;
        //}

        public override string ToString()
        {
            return $"Name: {Name}, School: {School}";
        }
    }
}
