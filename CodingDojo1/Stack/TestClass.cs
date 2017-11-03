using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class TestClass
    {
        public int Alter { get; set; }

        public TestClass(int alter)
        {
            this.Alter = alter;
        }

        public override string ToString()
        {
            return "Alter: "+Alter; 
        }

    }
}
