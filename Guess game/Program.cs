using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //User choose a level here
            int level;
            Console.WriteLine("Welcome to my Guessing Game");
            Console.WriteLine("There are 3 levels in this game: (1) Easy (2) Medium (3) Hard");
            Console.Write("Choose your level: ");
            level = Convert.ToInt32(Console.ReadLine());

            //Convert the guess to integer here
            int guess;
            if (Int32.TryParse("", out guess))
            {
                guess = Convert.ToInt32("");
            }
            else
            {
                guess = 0;
            }

            //For Easy Level which is 1
            if (level == 1)
            {
                int secretNumber = 5;
                int guessLimit = 6;
                int guessCount = 0;
                bool outOfGuesses = false;

                while (guess != secretNumber && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        int guessRemaining = guessLimit - guessCount;
                        Console.WriteLine("Enter your guess number between 1-10: ");
                        Console.WriteLine("You have " + guessRemaining + " guesses remaining");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if(guess != secretNumber)
                        {
                            Console.WriteLine("You are Wrong!!!");
                        }
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("Game Over!!!..You are out of guess");
                }
                else
                {
                    Console.Write("That's Right!!!");
                }
                Console.ReadLine();
            }
            //If the User choses the medium level which is 2
            else if(level == 2)
            {
                int secretNumber = 13;
                int guessLimit = 4;
                int guessCount = 0;
                bool outOfGuesses = false;

                while (guess != secretNumber && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        int guessRemaining = guessLimit - guessCount;
                        Console.WriteLine("Enter your guess number between 1-20: ");
                        Console.WriteLine("You have " + guessRemaining + " guesses remaining");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if(guess != secretNumber)
                        {
                            Console.WriteLine("You are wrong!!!");
                        }
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("Game Over!!!..You are out of guess");
                }
                else
                {
                    Console.Write("That's Right!!");
                }
                Console.ReadLine();
            }
            //Hard level which is 3
            else
            {
                int secretNumber = 37;
                int guessLimit = 3;
                int guessCount = 0;
                bool outOfGuesses = false;

                while (guess != secretNumber && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        int guessRemaining = guessLimit - guessCount;
                        Console.WriteLine("Enter your guess number between 1-50: ");
                        Console.WriteLine("You have " + guessRemaining + " guesses remaining");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if(guess != secretNumber)
                        {
                            Console.WriteLine("You are Wrong!!!");
                        }
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.Write("Game Over!!!..You are out of guess");
                }
                else
                {
                    Console.Write("That's Right!!");
                }
                Console.ReadLine();
            }

        }
    }
}
