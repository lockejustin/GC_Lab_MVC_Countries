using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_MVC_Countries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }


        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public Country GetUserSelection(List<Country> countries)
        {
            Country output;
            int userChoice;

            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    userChoice = int.Parse(input);
                    if (userChoice >=0 && userChoice < countries.Count)
                    {
                        output = countries[userChoice];
                        break;
                    }
                    else
                    {
                        Console.Write($"That is not a valid choice.  Please input a number between 0 and {countries.Count-1} ");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That choice wasn't a number.  Please try again.");
                }
            }

            return output;
        }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}
