﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            //Assign values
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1932, 6, 1);

            //output to the console window

            //use simple outpur with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //use placeholder style
            Console.WriteLine("{0} years old.",age);

            //use string concatenation
            Console.WriteLine(street +", " + city + ", " + country);

            //use string interpolation
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}