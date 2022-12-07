using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10
{
    internal class Work
    {
        internal string name;
        internal int number;
        internal string department;
        internal Work(string name)
        {
            this.name = name;
        }
        internal Work(string name, int number, string department)
        {
            this.name = name;
            this.number = number;
            this.department = department;
        }
    }
}