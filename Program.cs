using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System;

namespace IterationLoops
{
    internal class Program
    {

        //Write a method that will print to the console all numbers 1000 through -1000
        public static void Print1000s()
        {
            Console.WriteLine("Numbers 1000 through -1000");
            for (int k = -1000; k <= 1000; k++)
            {
                Console.WriteLine(k);
            }
        }



        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintThrees()
        {
            for (var d = 3; d <= 999; d += 3)
            {
                Console.WriteLine(d);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static void TwoIntsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal!");
            }
            else
            {
                Console.WriteLine("Numbers are NOT equal!");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even!");
            }
            else
            {
                Console.WriteLine($"{number} is odd!");
            }
        }


        //Write a method to check whether a given number is positive or negative

        public static void PositiveNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive!");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative!");
            }
            else
            {
                Console.WriteLine($"{num} is neither positive or negative!");
            }
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            bool userResponce;
            int result;

            do
            {
                Console.WriteLine("Enter an integer:");

                userResponce = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponce);

            if (result >= -10 && result <= 10)
            {
                Console.WriteLine($"{result} is between 10 & -10!");
            }
            else
            {
                Console.WriteLine($"{result} is NOT between 10 & -10!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an integer!");

                cont = int.TryParse(Console.ReadLine(), out userInput);

            } while (!cont);

            for (var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");

                userAge = int.TryParse(Console.ReadLine(), out result);

            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Sorry! You're too young!");
            }
            else
            {
                Console.WriteLine("Sweet! You can vote!");
            }
        }


        //Write a method that receives a name and age, and prints a greeting message to the console using the name.
        //if they can drive based off age tell them they can drive otherwise tell them sorry try again next time
        static string GreetingMessage(string name, int age)
        {
            Console.WriteLine($"Hello {name}!");

            if (age >= 16)
            {
                return "You can drive!";
            }
            else
            {
                return "You cannot drive yet!";
            }
        }


        public static void Main(string[] args)
        {
            //CALLING METHODS FROM ABOVE^^^^^
            Print1000s();
            PrintThrees();
            TwoIntsEqual(5, 9);
            TwoIntsEqual(4, 4);
            EvenOdd(10);
            EvenOdd(35);
            PositiveNegative(2);
            PositiveNegative(-20);
            PositiveNegative(0);
            InRange();
            MultTable();
            AgeCheck();
            //------------------




            Console.WriteLine("---------------------------------------------------------");
            //A FOR loop that counts from 0 - 100 by incrementing (0++), making it 0 - 100!~
            Console.WriteLine("Numbers incrememnting 0 - 100....");
            for (int b = 0; b <= 100; b++)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------------");

            //A WHILE loop that counts from 1 - 101 by incrementing (++1), making it 1 - 101!
            Console.WriteLine("Numbers incrememnting 1 - 101....");
            int z = 0;
            while (z <= 100)
            {
                Console.WriteLine(++z);
            }

            Console.WriteLine("-------------------");

            //A FOR loop that starts at A and loops to Z in uppercase form and lowercase!
            char i;
            Console.WriteLine("Uppercase Alphabet letters from A to Z:\n ");
            for (i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("Lowercase Alphabet letters from a to z:\n");
            for (i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("---------------");

            //Make a LIST of video games & make a FOREACH LOOP that displays each video game!
            Console.WriteLine("A few favorite games...");
            List<string> myVideoGames = new List<string>()
                { "Skyrim", "Elder Scrolls Online", "Cyberpunk 2077", "Animal Crossing", "GTA", };

            foreach (string game in myVideoGames)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("-----------------");


            //Make a LIST of everyone in your house!
            Console.WriteLine("My family!");
            List<string> peopleInMyHouse = new List<string>()
                { "Monica", "Jake", "Audrey", "Benjamin", "Gypsy Cat"};

            foreach (string person in peopleInMyHouse)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("-----------------");


            //Make a FOR LOOP with the current number (c), if the current number is EVEN - display ALL EVEN #'s!
            //Make another FOR LOOP with the current number (d), if the current number is ODD - display ALL ODD #'s!

            int c = 0;
            Console.WriteLine("Even Numbers:\n");
            for (c = 1; c <= 100; c++)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine(c + " ");
                }
            }

            Console.WriteLine("---------------");

            int d = 0;
            Console.WriteLine("Odd Numbers:\n");
            {
                for (d = 1; d <= 100; d++)
                {
                    if (d % 2 != 0)
                    {
                        Console.WriteLine(d + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------");

            //FOR loop that decrements from 200 to 1!
            for (int n = 200; n >= 1; --n)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("---------------");

            //WHILE loop that decrements from 200 to 1!
            int p = 200;
            while (p >= 1)
            {
                Console.WriteLine(p--);
            }

            Console.WriteLine("---------------");

            //Make a LIST of (string) everyone in your house & their birthdays!
            Console.WriteLine("My family and their birth dates...");
            List<string> familyBirthDates = new List<string>()
                { "Monica, 9/1/94", "Jake, 12/17/91", "Audrey, 12/19/17", "Ben, 12/30/20" };

            foreach (string familybirthday in familyBirthDates)
            {
                Console.WriteLine(familybirthday);
            }

            Console.WriteLine("---------------");

            //FOR loop that increments from 1 - 10 (x++)!
            Console.WriteLine("Loop that increments from numbers 1 - 10");
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------");

            //FOR loop that decrements from 10 - 0 (--y)!
            Console.WriteLine("Loop that decrements from numbers 10 - 1");
            for (int y = 10; y >= 0; --y)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("---------------");

        }

    }


}


