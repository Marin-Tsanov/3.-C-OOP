﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    public static class MyExtensions
    {
        public static void Print(this string input)
        {
            Console.WriteLine(input);
        }
    }
}
