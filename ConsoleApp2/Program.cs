﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
           Console.WriteLine(class1.CheckVIN("JHMCM56557C402253"));
           Console.WriteLine(class1.GetVINCountry("JHMCM56557C402253"));
           Console.ReadKey();
        }
    }
}