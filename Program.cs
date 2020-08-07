using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace GC_Lab_MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>
            {
                new Country("United States", Continent.NorthAmerica, new List<string> {"Red", "White", "Blue"}, new List<ConsoleColor>{ ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue}),
                new Country("Canada", Continent.NorthAmerica, new List<string>{"Red", "White"}, new List<ConsoleColor>{ ConsoleColor.Red, ConsoleColor.White}),
                new Country("Sweden", Continent.Europe, new List<string>{"Blue", "Yellow"}, new List<ConsoleColor> { ConsoleColor.Blue, ConsoleColor.Yellow}),
                new Country("Australia", Continent.Oceana, new List<string>{"Red", "White", "Blue"}, new List<ConsoleColor>{ ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue}),
                new Country("Japan", Continent.Asia, new List<string>{"Red","White" }, new List<ConsoleColor>{ ConsoleColor.Red, ConsoleColor.White}),
                new Country("Brazil", Continent.SouthAmerica, new List<string>{"Green", "Yellow", "Blue", "White"}, new List<ConsoleColor>{ ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.White})
            };

            CountryController c = new CountryController(countries);
            c.WelcomeAction();

        }
    }
}
