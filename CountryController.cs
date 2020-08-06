using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_MVC_Countries
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public CountryController()
        {

        }  
        public CountryController(List<Country> countryDB    )
        {
            CountryDB = countryDB;
        }

        public void CountryAction(Country c)
        {
            CountryView v = new CountryView(c);
            v.Display();
            
        }

        public void WelcomeAction()
        {
            while (true)
            {
                CountryListView v = new CountryListView(CountryDB);
                Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list:");
                v.Display();
                Country choice = v.GetUserSelection(CountryDB);

                CountryAction(choice);

                Console.Write("Would you like to learn about another country? (y/n) ");
                string input = Console.ReadLine().ToLower();

                while (input != "y" && input != "n")  //answer validation
                {
                    Console.Write("Invalid entry.  Please answer (y/n) ");
                    input = Console.ReadLine().ToLower();
                }

                if (input == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for using the program.  Goodbye!");
                    break;
                }
            }
        }
    }
}
