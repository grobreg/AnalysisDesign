using System;

namespace AppAnalysisDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "Gabriel";
            string lastName = "Regio";

            Console.WriteLine(firstName + " - " + lastName);

            Program.PrintVars();

            char c = 'a';
            Console.WriteLine(Program.IsVowel(c));

            char w = 'w';
            Console.WriteLine(Program.IsVowel(w));

            // Exercise 1: write a function that determines if a character is a letter or not
            char x = 'g';
            Console.WriteLine(Program.isLetter(x));
            // Exercise 2: write a function that determines if a character is a number or not
            char y = '5';
            Console.WriteLine(Program.isNumber(y));

            char z = '?';
            Console.WriteLine(Program.isNumber(z));
        } 

        public static bool isLetter(char x)
        {
            // if (x == 'a' || x == 'b' || x == 'c' || x == 'd' || x == 'e' || x == 'f' || x == 'g' || x == 'h' || x == 'i' || x == 'j' || x == 'l' || x == 'k' || x == 'l' || x == 'm' || x == 'n' || x == 'o' || x == 'p' || x == 'q' || x == 'r' || x == 's' || x == 't' || x == 'u' || x == 'v' || x == 'w' || x == 'y' || x == 'z')
            if (x >= 65 && x <= 122)
            {
                Console.WriteLine("The character is a letter!");
                return true;
            }

            else
                Console.WriteLine("It is not a letter");
            return false;
        }
        public static bool isNumber(char y)
        {
            if (y >= 48 && y <= 57)
            // if (y == '0' || y == '1' || y == '2' || y == '3' || y == '4' || y == '5' || y == '6' || y == '7' || y == '8' || y == '9')
                return true;
            return false;
        }
        public static void PrintVars()
        {
            int year = 2021;
            bool isClassStarted = true;

            Console.WriteLine("year: {0} isClassStarted: {1}", year, isClassStarted);
        }

        public static bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                return true;

            return false;
        }

        // .net code gets build into IL
        // IL code gets converted to native code the first time we run it
        // - Just-in-time compile runs and converts into native code
        // - then runs the native code
        // the next time we run the app it will be the executable that runs

        // Automatic memory management
        // CLR - common language runtime
        // GC - Garbage Collector
        // update.
    }
}
