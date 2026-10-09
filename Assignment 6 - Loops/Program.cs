using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_6___Loops
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {

            

            string bankChoice;
            int minValue, maxValue, middleValue;
            double choice, deposit, balance, withdrawal, bill;
            bool resetMenu, reset1, reset2, reset3, doubleRoll;

            resetMenu = false;
            reset1 = false;
            reset2 = false;
            reset3 = false;
            doubleRoll = false;
            

            choice = 0;
            

            while (!resetMenu) 
            {

                Console.WriteLine();
                Console.WriteLine("What would You Like To Do?");
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Simple Banking Machine");
                Console.WriteLine("3 - Doubles Roller");
                Console.WriteLine("Press 4 or ENTER To Exit");
                if (Double.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();

                    //Choice 1:

                    if (choice == 1)
                    {
                        //while (!reset1)
                        //{


                            Console.WriteLine("Give me a number!");
                            if (Int32.TryParse(Console.ReadLine(), out minValue))
                            {
                                Console.WriteLine($"Ok-Your first number is: {minValue}");
                            }

                            else
                            {
                                Console.WriteLine("Invalid Input.");
                                resetMenu = false;
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
                                    resetMenu = true;

                                    resetMenu = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a NUMBER BETWEEN you max value and minimum value.");
                                    //reset1 = true;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Max Value Must be a NUMBER LARGER than you last number.");
                                //reset1 = true;
                            }


                        //}
                    }

                    //choice 2:

                    else if (choice == 2)
                    {
                        balance = 150;

                        Console.WriteLine("Welcome to the Bank of Blorb™ (BoB™)! What will you be doing today? (Please type out your choice)");
                        Console.WriteLine("deposit");
                        Console.WriteLine("withdrawal");
                        Console.WriteLine("bill payment");
                        Console.WriteLine("account balance");
                        Console.WriteLine("close");

                        //bankChoice = Console.ReadLine();

                        bankChoice = Console.ReadLine().ToLower().Trim();

                        //bankChoice.ToLower();

                        if (bankChoice == "deposit")
                        {
                            balance = balance - 0.75;
                            Console.WriteLine($"You Currently Have: ${balance}");

                            Console.WriteLine("How much will you be depositing?");
                            Double.TryParse(Console.ReadLine(), out deposit);

                            balance = balance + deposit;


                            Console.WriteLine($"You have ${balance}");
                        }

                        else if (bankChoice == "withdrawal")
                        {
                            balance = balance - 0.75;

                            Console.WriteLine($"You Currently have ${balance}");

                            Console.WriteLine("How much would you like to withdrawal?");
                            Double.TryParse(Console.ReadLine(), out withdrawal);

                            if (withdrawal > balance)
                            {
                                Console.WriteLine("You are too broke to take that much out.");
                            }

                            else
                            {
                                balance = balance - withdrawal;

                                Console.WriteLine($"You Now Have ${balance}");
                            }

                        }

                        else if (bankChoice == "bill payment")
                        {
                            balance = balance - 0.75;

                            Console.WriteLine($"You Currently have ${balance}");

                            Console.WriteLine("How much would you like to pay?");
                            Double.TryParse(Console.ReadLine(), out bill);

                            if (bill > balance)
                            {
                                Console.WriteLine("You are too broke. Get a job");
                            }

                            else
                            {
                                balance = balance - bill;

                                Console.WriteLine($"You Now Have ${balance}");
                            }

                        }

                        else if (bankChoice == "account balance")
                        {
                            balance = balance - 0.75;

                            Console.WriteLine($"You currently Have ${balance}");
                        }

                        else if (bankChoice == "close")
                        {
                            //return;

                            resetMenu = false;
                        }

                    }

                    //Choice 3:

                    else if (choice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Die1 die1 = new Die1();
                        Thread.Sleep(1);     //Adds a 1-millisecond delay, causing both randoms to generate seperetly, resulting in different numbers (mostly, unless you DO ge a double).
                        Die1 die2 = new Die1();

                        die1.Color = ConsoleColor.Cyan;
                        die2.Color = ConsoleColor.Green;

                        while (!doubleRoll)
                        {

                            die1.DrawRoll();
                            die1.RollDie();
                            die2.DrawRoll();
                            die2.RollDie();

                            Thread.Sleep(300);
                            Console.Clear();

                            if (die1.Roll == die2.Roll)
                            {

                                die1.DrawRoll();
                                die2.DrawRoll();

                                Console.WriteLine("Both die are the same-You got a Double!");

                                Console.WriteLine("Press ENTER To Close");
                                Console.ReadKey();
                                return;


                            }
                        }




                    }

                    //Choice 4:

                    else if (choice == 4) 
                    {
                        Console.Clear();
                        return;
                    }

                }

                else 
                {
                    Console.WriteLine("Invalid Input");
                    
                    resetMenu = true;
                }
                

                
            }

           

            



        }
    }
}
