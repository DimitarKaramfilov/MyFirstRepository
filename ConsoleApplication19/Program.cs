﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = "aa";
            string b = "a";
            b += "a";
            bool result = object.Equals(a, b);
        }
    }
}
