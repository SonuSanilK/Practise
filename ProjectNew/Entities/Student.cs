using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.Entities
{
    internal class Student
    {
        public string RegisterNumber { get; set; }
        public string Name { get; set; }

        public List<Exam> Exams { get; set; }
    }
}
