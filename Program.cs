using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I want to play a game.");
            Console.Write("Choose a level: ");
            Console.Write("simpleton, milktoast, or genius.  ");
            string level = Console.ReadLine();
            int allowedTries;

            if (level == "simpleton")
            {
                allowedTries = 8;
            }
            else if (level == "milktoast")
            {
                allowedTries = 6;
            }
            else if (level == "genius")
            {
                allowedTries = 4;
            }
            else
            {

                Console.WriteLine("Not a choice. Game over.");
                allowedTries = 0;
            }


            Console.WriteLine("There exists a number that will unlock eternity. Can you guess it?");
            int secretNumber = new Random().Next(1, 100);
            int guess = Convert.ToInt32(Console.ReadLine());


            int numberOfTries = 0;

            while (true)
            {
                
                numberOfTries++;

                if (numberOfTries == allowedTries)
                {
                    Console.WriteLine($"Your death is not a surprise. The number was {secretNumber}.");
                    break;
                }

                else if (guess > secretNumber)
                {

                    Console.WriteLine($"You have of course guessed too high. You have {allowedTries - numberOfTries} guesses remaining.");
                    guess = Convert.ToInt32(Console.ReadLine());

                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine($"Your ignorance is astounding, and your guess is too low. You have {allowedTries - numberOfTries} guesses remaining.");
                    guess = Convert.ToInt32(Console.ReadLine());

                }

                else if (guess == secretNumber)
                {
                    Console.WriteLine($"Indeed. It was {secretNumber}. You live another day.");
                    break;
                }


            }

        }


    }

}
