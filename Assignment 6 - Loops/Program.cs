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

            int minValue, maxValue, middleValue;
            double choice;
            bool resetMenu, reset1, reset2, reset3;

            resetMenu = false;
            reset1 = false;
            reset2 = false;
            reset3 = false;
            

            choice = 0;
            

            while (!resetMenu) 
            {
                Console.WriteLine("What would You Like To Do?");
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Simple Banking Machine");
                Console.WriteLine("3 - Doubles Roller");
                Console.WriteLine("Press 4 To Exit");
                if (Double.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();

                    if (choice == 1)
                    {
                        while (!reset1)
                        {


                            Console.WriteLine("Give me a number!");
                            if (Int32.TryParse(Console.ReadLine(), out minValue))
                            {
                                Console.WriteLine($"Ok-Your first number is: {minValue}");
                            }

                            else
                            {
                                Console.WriteLine("Invalid Input.");
                                //reset1 = true;
                            }


                            Console.WriteLine($"Give me a number bigger than {minValue}");
                            Int32.TryParse(Console.ReadLine(), out maxValue);

                            if (maxValue > minValue)
                            {
                                Console.WriteLine($"Okay, Give me a number between {minValue}, and {maxValue}!");
                                Int32.TryParse(Console.ReadLine(), out middleValue);

                                if (middleValue > minValue && middleValue < maxValue)
                                {
                                    Console.WriteLine($"Good Stuff! {middleValue} is right between {minValue} and {maxValue}!");
                                    reset1 = true;
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a NUMBER BETWEEN you max value and minimum value.");
                                    resetMenu = true;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Max Value Must be a NUMBER LAREGER than you last number.");
                                resetMenu = true;
                            }


                        }
                    }

                    else if (choice == 2) 
                    {
                        Console.WriteLine("Welcome to the Bank of Blorb™ (BoB™)! What will you be doing today?");
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdrawal");
                        Console.WriteLine("3 - Bill Payment");
                        Console.WriteLine("4 - Account Balance");
                        Console.WriteLine("5 - Close");
                        


                    }

                }

                else 
                {
                    Console.WriteLine("Invalid Input");
                    resetMenu = true;
                }
                

                
            }

            //Part 1

            



        }
    }
}
