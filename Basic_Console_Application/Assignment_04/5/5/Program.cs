﻿//5. Write a Program to Convert Upper case to Lower Case using LowerCase method 
//Ex: Enter the String in Uppercase : JALA String in Lowercase :jala

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;

            Console.Write("\n\nReplace lowercase characters by uppercase and vice-versa :\n");
            Console.Write("Input the string : ");

            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); 

            Console.Write("\nAfter conversion, the string is : ");

            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                {
                    Console.Write(Char.ToLower(ch));
                }
            }

            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
