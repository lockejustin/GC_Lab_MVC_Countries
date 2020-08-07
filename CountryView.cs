using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_MVC_Countries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"{DisplayCountry.Name}");
            Console.WriteLine($"{DisplayCountry.Continent}");

            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.ForegroundColor = DisplayCountry.PrintColor[i];
                Console.WriteLine($"{DisplayCountry.Colors[i]}");
            }

            Console.ResetColor();
        }

    }
}
