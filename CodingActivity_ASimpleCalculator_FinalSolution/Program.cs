using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingActivity_ASimpleCalculator_FinalSolution
{
    class Program
    {

        // **************************************************
        //
        // Title: A Simple Calculator
        // Description: Solution for developing a calculator that takes
        //    two integers as user input and performs a basic operation.
        // Application Type: Console
        // Author: Velis, John
        // Dated Created: (current date)
        // Last Modified: 8/18/2016
        //
        // **************************************************

        static void Main(string[] args)
        {
            //
            // variables
            //
            int num1;
            int num2;
            double answer = 0; // initialize for compiler check
            string operation = ""; // initialize for compiler check
            string userResponse;
            bool validOperation;
            bool quit;

            //
            // welcome screen
            //
            Console.WriteLine();
            Console.WriteLine("Welcome to A Simple Calculator");
            Console.WriteLine();
            Console.WriteLine("You will be prompted for two integers and a mathematical");
            Console.WriteLine("operation. The program will then output the answer.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // 
            // application loop
            //
            quit = false; // set boolean for while loop
            while (!quit)
            {
                //
                // calculator screen - get user responses
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("A Simple Calculator");
                Console.WriteLine();

                //
                // get the first number and parse it
                //
                Console.WriteLine();
                Console.Write("Enter the first number: ");
                userResponse = Console.ReadLine();
                num1 = int.Parse(userResponse);

                //
                // get the second number and parse it
                //
                Console.WriteLine();
                Console.Write("Enter the second number: ");
                userResponse = Console.ReadLine();
                num2 = int.Parse(userResponse);

                //
                // get the operation
                //
                validOperation = false; // set boolean for while loop
                while (!validOperation)
                {
                    Console.WriteLine();
                    Console.WriteLine("ADD, SUBTRACT, MULTIPLY, DIVIDE, QUIT");
                    Console.WriteLine("Enter one of the operations above:");
                    userResponse = Console.ReadLine();
                    operation = userResponse.ToUpper();

                    if (operation == "ADD")
                    {
                        answer = num1 + num2;
                        validOperation = true;
                    }
                    else if (operation == "SUBTRACT")
                    {
                        answer = num1 - num2;
                        validOperation = true;
                    }
                    else if (operation == "MULTIPLY")
                    {
                        answer = num1 * num2;
                        validOperation = true;
                    }
                    else if (operation == "DIVIDE")
                    {
                        answer = num1 / num2;
                        validOperation = true;
                    }
                    else if (operation == "QUIT")
                    {
                        quit = true;
                    }
                    else
                    {
                        Console.WriteLine("It appears that you did not enter a valid operation.");
                        Console.WriteLine("Please try again.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                }

                if (!quit)
                {
                    //
                    // calculator screen - display answer
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("A Simple Calculator");
                    Console.WriteLine();

                    Console.WriteLine("Number 1: {0}", num1);
                    Console.WriteLine("Number 2: {0}", num2);
                    Console.WriteLine("Operation: {0}", operation);
                    Console.WriteLine("Answer: {0}", answer);

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    //
                    // closing screen
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("A Simple Calculator");
                    Console.WriteLine();

                    Console.WriteLine("Thank you for using our application.");

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }

            }


        }
    }
}
