using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ar = new SortedList();

            ar.Add(1, "One Ring To Rule Them All");
            ar.Add(2, "Sam helped Frodo");
            ar.Add(3, "Snow White");

            Console.WriteLine("The snow whhite value is at inex " + ar.IndexOfValue("Snow White") + ". :)");
            Console.Read();
        }
    }
}