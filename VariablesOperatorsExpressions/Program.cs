using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jordan";
            //Console.WriteLine(name);

            name = "Dave";
            //Console.WriteLine(name);
            //Case matters when naming variables 
            string Name = "Jordan";

            string birthMonth = "December";

            //Console.WriteLine(birthMonth);
            //integers
            int birthMonthNumber = 12;
            int age = 65;
            int population = 100000;
            //Floating type variables 
            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);



            //Boolean 
            bool isPresent = true;
            bool seatTaken = false;

            //Character
            char lastLetter = 'j';

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge > samAge);
            Console.WriteLine(jessicaAge + samAge);


        }
    }
}
