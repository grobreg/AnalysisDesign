using System;

namespace AppAnalysisDesign
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1: write a function that determines if a character is a letter or not
            char x = 'g';
            Console.WriteLine(Program.isLetter(x));
            // Exercise 2: write a function that determines if a character is a number or not
            char y = '5';
            Console.WriteLine(Program.isNumber(y));
            // Exercise 3: write a function that converts a Char to lowercase of the same Char
            convertToLower();
            // Exercise 4: write a function that converts a Char to uppercase of the same Char
            convertToUpper();
            // Exercise 5: write a function that converts every character in a string to lowercase using the function you wrote in Exercise 3
            convertLetterLower();
            // Exercise 6: write a function that converts every character in a string to uppercase using the function you wrote in Exercise 4
            convertLetterUpper();

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
            {
                // if (y == '0' || y == '1' || y == '2' || y == '3' || y == '4' || y == '5' || y == '6' || y == '7' || y == '8' || y == '9')
                Console.WriteLine("The character is a number!");
                return true;
            }
            return false;
        }

        public static void convertLetterLower()
        {
            {
                char t = 'X';
                char a = (char)(t + 32);
                Console.WriteLine($"Converted the LETTER {t} to lowercase: {a}\n");
            }
        }

        public static void convertLetterUpper()
        {
            {
                char t = 'x';
                char a = (char)(t - 32);
                Console.WriteLine($"Converted the LETTER {t} to uppercase: {a}\n");
            }
        }

        public static void convertToLower()
        {
            string letter1 = "HELLO";
            for (int i = 0; i < letter1.Length; i++)
            {
                char convertedLetter = (char)(letter1[i] + 32);
                Console.WriteLine($"The string is converted to lowercase: {convertedLetter}\n");
            }
        }

        public static void convertToUpper()
        {
            string letter1 = "apple";
            for (int i = 0; i < letter1.Length; i++)
            {
                char convertedLetter = (char)(letter1[i] - 32);
                Console.WriteLine($"The string is converted to uppercase: {convertedLetter}\n");
            }
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
