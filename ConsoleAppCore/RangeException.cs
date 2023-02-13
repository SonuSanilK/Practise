using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    internal class RangeException: Exception
    {
        public RangeException() : base() 
        {
        }

        public RangeException(string message) : base(message)
        {

        }
    }
}
