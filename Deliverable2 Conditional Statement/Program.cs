//Author: Yanjun Yang
//Date:1/20/2019
//Comments: This deliverable demostrates the use of conditional statement after getting input from users.

using System;

namespace Deliverable2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input.
            Console.WriteLine("Please enter your expect grade in ISM4300.");

            //Use try catch block to validate user input
            try
            {
                //This variable will gather the user input
                string input = Console.ReadLine();

                //This variable will be used to store grade after the input variable is parsed to integer.
                int grade = int.Parse(input);

                // This if/else if/else statement is used to conditionally test the user input.
                if ((grade > 97)&&(grade<101))
                    Console.WriteLine("Your grade is A+.");
                else if ((grade > 92) && (grade < 98))
                    Console.WriteLine("Your grade is A.");
                else if ((grade > 89) && (grade < 92))
                    Console.WriteLine("Your grade is A-.");
                else if ((grade > 87) && (grade < 90))
                    Console.WriteLine("Your grade is B+.");
                else if ((grade > 81) && (grade < 88))
                    Console.WriteLine("Your grade is B.");
                else if ((grade > 79) && (grade < 82))
                    Console.WriteLine("Your grade is B-.");
                else if ((grade > 77) && (grade < 80))
                    Console.WriteLine("Your grade is C+.");
                else if ((grade > 71) && (grade < 78))
                    Console.WriteLine("Your grade is C.");
                else if ((grade > 69) && (grade < 72))
                    Console.WriteLine("Your grade is C-.");
                else if ((grade > 67) && (grade < 70))
                    Console.WriteLine("Your grade is D+.");
                else if ((grade > 61) && (grade < 68))
                    Console.WriteLine("Your grade is D.");
                else if ((grade > 59) && (grade < 62))
                    Console.WriteLine("Your grade is D-.");
                else
                    Console.WriteLine("Your grade is F.");
                // end of if/else if/else statement.
                               
            }// end of try

            catch
            {
                Console.WriteLine("Please enter an integer.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey(true);
            }// end of catch
        }// end of main
    }// end of class
}// end of namespace
