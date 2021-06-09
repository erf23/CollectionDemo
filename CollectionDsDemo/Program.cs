using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Linus Torvalds");
            names.Add("Grace Hopper");
            names.Add("Jean Bartik");

            DisplayNames(names);
            Console.WriteLine("Count of list: " + names.Count);
            Console.WriteLine("Capacity of list: " + names.Capacity);

        }

        private static void DisplayNames(List<string> names)
        {
            for (int i = 0; i < names.Count; ++i)
            {
                Console.WriteLine((i + 1) + "; " + names[i]);
            }
            Console.WriteLine();
        }
    }
}
