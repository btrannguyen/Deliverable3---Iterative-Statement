/*
 Author: Tran Nguyen
 Date: 1/26/2023
 Description: using C# Console Application to demonstrate Iterative Statement
*/

using System;
using System.Linq.Expressions;

namespace Deliverable3___Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            string series = "";
            Boolean done = false;

            while (!done)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Pleaser enter an interger between 1 and 100");
                        input = int.Parse(Console.ReadLine());
                        if (input >= 1 && input <= 100)
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Please specify the series of integer numbers: Odd or Even");
                        series = Console.ReadLine();
                        if (series == "Odd" || series == "Even")
                        {
                            break;
                        }
                    }

                    if (series == "Odd")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    if (series == "Even")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Only interger is allowed");
                }
            }

        }    
        
    }
}