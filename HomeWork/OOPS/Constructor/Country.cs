using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Country
    {
        string country_name;
        int no_of_lang_spoken;
        int no_of_states;
        string Capital;
        public string CountryName
        {
            get { return country_name; }
            set { country_name = value; }
        }
        public int NoOfStates
        {
            get { return no_of_states; }
            set { no_of_states = value; }
        }
        public int NoOFLangSpoken
        {
            get { return no_of_lang_spoken; }
            set { no_of_lang_spoken = value; }
        }

        public string Capital1
        {
            get { return Capital;}
            set { Capital = value; }    

        }


    }
        class q1
    {
        static void Main(string[] args)
        {
            Country C1 = new Country();

            C1.CountryName = "India";
            C1.NoOFLangSpoken = 40;
            C1.NoOfStates = 26;
            C1.Capital1 = "Delhi";

            Console.WriteLine("Country Name: " + C1.CountryName);
            Console.WriteLine("Number of States: " + C1.NoOfStates);
            Console.WriteLine("Number Of Languages " + C1.NoOFLangSpoken);
            Console.WriteLine("Capital is "+ C1.Capital1);
        }
    }
}