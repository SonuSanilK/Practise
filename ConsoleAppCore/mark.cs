using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    internal class Student
    {
        public string Name;
        public List<Mark> NewList = new List<Mark>();

    }

    public class Mark
    {
        public string ExamName;
        public string Subject;
        public int MarkScored;
        public int MaxMark;
    }
}

