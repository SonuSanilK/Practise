using ConsoleAppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleAppCore
{
    internal class Students
    {
        public string name;

        public int mark1;

        public int mark2;

        public int total
        {
            get
            {
                return mark1 + mark2;
            }


        }
    }
}


internal class student
{
    public string Name { get; set; }
    public List<Mark> Marks { get; set; }

   
}

