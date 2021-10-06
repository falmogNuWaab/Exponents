using System;

namespace ExponentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter an integer              
            //Display a table of square and cubes from 1 to the value entered
            //Prompt the user to continue
            Console.WriteLine("Let's find some exponents!");
            bool ctnu = true;

            while (ctnu)
            {
                int nExpon;
                string expon = GetInput("Enter an integer: ");
                //int.MaxValue gives me the maximum value that ints can hold which is 2147483647
                if (!int.TryParse(expon, out nExpon) || int.Parse(expon) > int.MaxValue || int.Parse(expon) <= 0)                
                {
                    Console.WriteLine("That was not an valid number");
                    ctnu = Continue();
                    if(ctnu == false)
                    {
                        break;
                    }
                }
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t=====");
                //Console.WriteLine(expon);
                //Console.WriteLine(nExpon);
                for(int i=1; i<=nExpon; i++)
                {
                    int nSquare = MakeSquares(i);
                    int nCube = MakeCubes(i);
                    Console.WriteLine($"{i,5}\t\t{nSquare,7}\t\t{nCube,5}");
                    //Console.WriteLine($"{i}\t\t{nSquare}\t\t{nCube}");
                }
                ctnu = Continue();

            }
         
        }
        
        public static int MakeSquares(int number)
        {
            int squares = number * number;
            return squares;
        }

        public static int MakeCubes(int number)
        {
            int cubes = number * number * number;
            return cubes;
        }
        
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string response = Console.ReadLine();

            return response;

        }
        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue?(y/n) ");
            answer = answer.ToLower();

            if(answer == "y")
            {
                return true;
            }
            else if(answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that.");
                Console.WriteLine("Let's try again.");
                return Continue();
            }
        }
    }
}
