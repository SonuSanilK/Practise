using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    internal class Emp
    {
            public string Name { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return $"Name: {Name} | Salary : {Salary}";
            }
        }
    }

