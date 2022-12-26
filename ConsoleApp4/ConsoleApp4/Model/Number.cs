using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal abstract class Number
    {
        public int num1;
        public int num2;

        
        public Number(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public abstract void islem();
    }
}
