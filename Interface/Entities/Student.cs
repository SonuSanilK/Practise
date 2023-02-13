using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    internal interface IStudent
    {
        public string Name { get; set; }

        public void GetData();

        public void Display();
    }
}
