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

                catch (NegativeMilesException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                catch (DivideByZeroException ex)
                {

                    Console.WriteLine("Can't divide by zero!");
                    Console.WriteLine("");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("");
                    Console.WriteLine(ex.StackTrace);

                }
                catch (FormatException ex)
                {

                    Console.WriteLine("Not a valid number!");
                    Console.WriteLine("");
                    // Console.WriteLine(ex.HResult.ToString("X"));// X converts the error number to a hexadecimal number – шестнадцатеричное число- of error to look for 
                    Console.WriteLine("");
                    Console.WriteLine(ex.ToString());


                }

                // general Exception should be below all specific!
                catch (Exception ex)
                {

                    Console.WriteLine("Error!");
                }

                finally
                {
                    Console.WriteLine("Thanks for playing!");
                }

               
                Console.Write("Try again?");

                //anything, but n/N will continue the  loop
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
