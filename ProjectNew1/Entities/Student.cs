using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew1.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public string RegisterNumber { get; set; }

        public List<Exam> Exams { get; set; }
    }
}
