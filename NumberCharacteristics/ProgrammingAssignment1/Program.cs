﻿using System;

namespace ProgrammingAssignment1
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        // number to classify
        static int number;

        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract number from string
                GetInputValueFromString(input);

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed
                int a=Int16.Parse(input);
                if (a % 2 == 0)
                {
                    Console.Write("e ");

                    if (a > 0)
                    {
                        Console.WriteLine(1);
                    }else if (a == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else
                {
                    Console.Write("o ");
                    
                    if (a > 0)
                    {
                        Console.WriteLine(1);
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
               

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts the number from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValueFromString(string input)
        {
            number = int.Parse(input);
        }
    }
}
