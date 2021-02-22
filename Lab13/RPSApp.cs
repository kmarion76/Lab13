using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RPSApp 
    {
        public RPSApp()
        {

        }
        public static void GamePlay()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine(string.Empty);

            Console.WriteLine("Enter your name: ");
            string PlayerName = Console.ReadLine();
            Console.WriteLine(string.Empty);

            Console.WriteLine("Would you like to play against The Jets or The Sharks (j/s)?: ");
            string PlayerOpponent = Console.ReadLine();
            Console.WriteLine(string.Empty);


            

            string userContinue;
            do
            {

                Console.WriteLine("Rock, paper, or scissors? (r/p/s)");
                Console.WriteLine(string.Empty);

                var userResponse = HumanPlayer.GenerateRPS();
                Console.WriteLine(PlayerName + ": " + userResponse);

                if (PlayerOpponent.Equals("j", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Jets: " + RandomPlayer.GenerateRPS());
                    if (userResponse == RandomPlayer.GenerateRPS())
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (userResponse == RPS.Paper && RandomPlayer.GenerateRPS() == RPS.Rock)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (userResponse == RPS.Scissors && RandomPlayer.GenerateRPS() == RPS.Paper)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (userResponse == RPS.Rock && RandomPlayer.GenerateRPS() == RPS.Scissors)
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }

                }
                else if (PlayerOpponent.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Sharks: " + RockPlayer.GenerateRPS());
                    if (userResponse == RockPlayer.GenerateRPS())
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (userResponse == RPS.Paper)
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                    
                }

                else
                {
                    Console.WriteLine("You did not select a valid opponent. Please enter 'j' or 's': ");
                }

                Console.WriteLine(string.Empty);
                Console.WriteLine("Play again? (y/n): ");
                userContinue = Console.ReadLine();

            } while (userContinue.Equals("y", StringComparison.OrdinalIgnoreCase));
            
            




        }
    }

}
