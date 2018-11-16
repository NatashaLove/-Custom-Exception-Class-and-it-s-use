using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Trip t = new Trip();

                try
                {
                    Console.WriteLine("How many miles did you go?");
                    t.Miles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many gallons did you use?");
                    t.Gallons = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You got about {0} miles per gallon.", t.MPG);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Can't divide by zero!");
                }
                finally
                {
                    Console.WriteLine("Thanks for playing!");
                }

               
                Console.Write("Try again?");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
            }


            Console.WriteLine("Press any button..");
            Console.ReadKey();
              
        }
    }
}
