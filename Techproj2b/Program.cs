// Author: T. Jarrett Hopple
// Class: ISM 4300
// Assignment: Tech Proj #2b

using System;

namespace Techproj2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("What grade do you expect to get in ISM 4300: ");

                // This will gather user data
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                
                // if 90 to 100 grade is A
                if ((value_of_input <= 100) && (value_of_input >= 90))
                {
                    Console.WriteLine(" Letter grade: A");
                }

                // if 80 to 89 grade is B
                if ((value_of_input < 90) && (value_of_input >= 80))
                {
                    Console.WriteLine(" Letter grade: B");
                }

                // if 70 to 79 grade is C
                if ((value_of_input < 80) && (value_of_input >= 70))
                {
                    Console.WriteLine(" Letter grade: C");
                }

                // if 60 to 69 grade is D
                if ((value_of_input < 70) && (value_of_input >= 60))
                {
                    Console.WriteLine(" Letter grade: D");
                }
                
                // if less than 60 grade is F
                if ((value_of_input < 60) && (value_of_input >= 0))
                {
                Console.WriteLine(" Letter grade: F");
                }

                // read and exit the program 
            Console.WriteLine(" Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}
