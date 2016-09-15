using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingActivity_ASimpleCalculator_StarterSolution
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
        // Dated Created: 8/18/2016
        // Last Modified: 
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
            bool validResponse;
            bool quit;

            //
            //  application screen - welcome
            //
            Console.WriteLine();

            //
            // INSERT CODE
            //

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // 
            // application loop
            //
            quit = false; // set boolean for while loop
            while (!quit)
            {
                //
                // application screen - get numbers from users
                //

                //
                // INSERT CODE
                //

                //
                // get the first number and parse it
                //

                //
                // INSERT CODE
                //

                //
                // get the second number and parse it
                //

                //
                // INSERT CODE
                //

                //
                // get the operation with valid response
                //
                validResponse = false; // set boolean for while loop
                while (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("ADD");
                    Console.WriteLine("Enter one of the operations above:");
                    userResponse = Console.ReadLine();
                    operation = userResponse.ToUpper();

                    if (operation == "ADD")
                    {
                        validResponse = true;
                    }
                    //
                    // user did not provide a valid menu option
                    else
                    {

                        //
                        // INSERT CODE
                        //

                    }
                }

                //
                // application screen - display answer
                //

                //
                // INSERT CODE
                //

                //
                // Student - echo user numbers and answer
                //

                //
                // INSERT CODE
                //
                
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                //
                // get continue response from user with validation
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // application screen - prompt user for another calculation
                    //

                    userResponse = Console.ReadLine();
                    if (userResponse == "YES")
                    {

                        //
                        // INSERT CODE
                        //

                    }
                    else if (userResponse == "NO")
                    {

                        //
                        // INSERT CODE
                        //

                    }
                    else
                    {

                        //
                        // INSERT CODE
                        //

                    }
                }
            }

            //
            // INSERT CODE
            //

        }
    }
}

