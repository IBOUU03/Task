﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Divide:Number
    {
        public Divide(int num1, int num2) : base(num1, num2)
        {

            islem();

        }

        public override void islem()
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
