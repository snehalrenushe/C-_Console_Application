﻿//3. Write a program of built in type conversion methods
//Ex:
//Input :
//Enter string name
//Enter Integer value
//Output :
//string to float - 34.6
//int to double - 337

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
