using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6___Loops
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {

            int minValue, maxValue;
            bool resetMenu, reset1, reset2, reset3;

            //Part 1

            Console.WriteLine("Give me a number!");
            if (Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Console.WriteLine($"Ok-Your first number is: {minValue}");
            }

            else 
            {
                
            }

                Console.WriteLine($"Give me a number bigger than {minValue}");



        }
    }
}
