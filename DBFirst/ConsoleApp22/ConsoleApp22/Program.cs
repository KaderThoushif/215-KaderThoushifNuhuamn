﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark", "Jhon" , "Kader", "Saifud",
                "Safeeu" , "Abdullah" , "Meenakshi",
                "Mohamed", "Nuhuman", "Munasir" };

            UsingLinq(names);
        }
        private static void UsingLinq(string[] names)
        {

            // LINQ Query 
            IEnumerable<string> query = from s in names
                                        where s.Length > 5
                                        where s.Contains('a')
                                        orderby s
                                        select s.ToUpper();

            // Query execution
            foreach (string item in query)

                Console.Write(item + "\n");
                Console.Read();
        }
    }
}
