using System;
using System.Collections.Generic;

namespace GC_Lab_MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>
            {
                new Country("United States", Continent.NorthAmerica, new List<string> {"Red", "White", "Blue"}),
                new Country("Canada", Continent.NorthAmerica, new List<string>{"Red", "White"}),
                new Country("Sweden", Continent.Europe, new List<string>{"Blue", "Yellow"}),
                new Country("Australia", Continent.Oceana, new List<string>{"Red", "White", "Blue"}),
                new Country("Japan", Continent.Asia, new List<string>{"Red","White" }),
                new Country("Brazil", Continent.SouthAmerica, new List<string>{"Green", "Yellow", "Blue", "White"})
            };

            CountryController c = new CountryController(countries);
            c.WelcomeAction();

        }
    }
}
