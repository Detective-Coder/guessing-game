using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number.");
            Console.WriteLine();
            GuessQuestion();
        }

        static void ComputerSays(string message) 
        {
          Console.WriteLine($@"{message}");
        }

        static bool ComputerAsks(string question)
        {
          // int randomNumber = new Random().Next(1, 100);
          // Console.WriteLine(randomNumber);

          for (int i = 1; i <= 4; i++) {
            Console.Write($"{question} ");
            Console.Write($"This is guess {i} of 4 ");

            string answer = Console.ReadLine().ToLower(); 

            if (answer == "42")
            {
              return true;
            }
            
          }
          return false;
        }

        static void GuessQuestion()
        {
          bool isTrue = ComputerAsks("What's your guess?");
          if (isTrue)
          {
            ComputerSays("That's right!");
          }
          else
          {
            ComputerSays("WRONG");
          }
        }

        // Die Roll()
        // {
        //   int dieValue = new Random().Next(1, 6);
        //   Die die = new Die(dieValue);
        //   return die;
        // }
    }
}
