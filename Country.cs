using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GC_Lab_MVC_Countries
{
    public enum Continent
    {
        Africa,
        Antarctica,
        Asia,
        Europe,
        NorthAmerica,
        Oceana,
        SouthAmerica
    }
    
    class Country
    {
        public string Name { get; set; }

        public Continent Continent { get; set; }

        public List<string> Colors { get; set; }
        public List<KnownColor> Colors2 { get; set; }

        public Country(string name, Continent continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }



    }

    
}
