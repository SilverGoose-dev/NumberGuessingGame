using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsRealInteger;
            Random rand = new Random();
            int randomNumber = rand.Next(20) + 1;
            int userNumberGuess = 0;
            int GuessCounter = 1;
            int PreviousGuess = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            while (randomNumber != userNumberGuess)
            {
                Console.Write("Please Enter a Number Between 1 and 20: ");
                string userInput = Console.ReadLine();
                IsRealInteger = int.TryParse(userInput, out userNumberGuess);

                if (IsRealInteger == false || userNumberGuess > 20 || userNumberGuess < 1)
                {
                    Console.WriteLine("Please choose a whole number within the range.");
                    continue;
                }

                if (randomNumber > userNumberGuess)
                {
                    Console.WriteLine($"The number is more than {userNumberGuess}");
                    if (userNumberGuess != PreviousGuess)
                        GuessCounter++;

                }
                else if (randomNumber < userNumberGuess)
                {
                    Console.WriteLine($"The number is less than {userNumberGuess}");
                    if (userNumberGuess != PreviousGuess)
                        GuessCounter++;
                }
                else
                {
                    Console.WriteLine($"You got it right!!!! The number is: {userNumberGuess}");
                    Console.WriteLine($"It only took you {GuessCounter} tries.");
                }
                PreviousGuess = userNumberGuess;
            }

            Console.WriteLine("Thank you for playing!!");
            }
        }
    }

    
