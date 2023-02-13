using ProjectNew1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew1.Entities
{
    internal class Exam
    {
        public int MarkScored { get; set; }
        public List<ExamType> ExamTypes;

        public List<Subject> Subjects;

    }
}
