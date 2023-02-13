using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    internal class Employee
    {
        public string Name { get; set; }

        public int _age;

        public int Age
        {
            get { return _age; }


               set {
                    if (value >= 0 && value <= 100)
                        _age = value;
                }
            
        }
    }
}
