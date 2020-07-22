using System;

namespace powersTable
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {

            bool cont = true;

            //INTRO
            Console.WriteLine("***** Hello and Welcome to the Powers Table! *****");
            Console.WriteLine("Learn your squares and cubes here!");

            //Begin loop for continuance
            while (cont)
            {
                //Call validation method
                double num = ValidateNumber("Please enter an integer for how high of a number you want to see calculations done.");

                //Create headers
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t======\t\t======");

                //Perform calculations & print
                Calculations(num);
                //COOL SOUNDS & STUFF
                Console.Beep(); Console.Beep(); Console.Beep();

                //Ask user if they want to continue
                cont = ContinueProgram(cont);
            }

            //Say goodbye
            Console.WriteLine("Have a Terrific day! \n");
        }

        // This method checks to validate the number entered by the user
        public static double ValidateNumber(string message)
        {
            double num = 0;
            bool invalid = true;

            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (invalid)
            {
                //check to make sure input is an actual number
                if (Double.TryParse(input, out num))
                {
                    //check to make sure the number entered is >= 1
                    if (num < 0)
                    {
                        Console.WriteLine("Sorry, that is not a positive number. Please try again");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        invalid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid number, please enter a positive number.");
                    input = Console.ReadLine();
                }
            }

            return num;
        }

        //This method performs calculations for squares and cubes to the user's number
        public static void Calculations(double number)
        {
            double count = 0;

            double squareNum = 0;
            double cubeNum = 0;

            for (double i = 1; i <= number; i++)
            {
                count = i;

                Console.Write(count + "\t\t");
                
                squareNum = Math.Pow(count, 2);
                Console.Write(squareNum + "\t\t");

                cubeNum = Math.Pow(count, 3);
                Console.Write(cubeNum + "\t\t");

                Console.WriteLine();
            }
        }

        //This method prompts the user to continue after each run
        public static bool ContinueProgram(bool cont)
        {
            Console.WriteLine("Would you like to continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();

            while (cont)
            {
                if (input[0] == 'y')
                {
                    cont = true;
                    break;
                }
                else if (input[0] == 'n')
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please enter y/n.");
                    input = Console.ReadLine();
                    input = input.ToLower();
                }
            }
            return cont;
        }

    }
}
