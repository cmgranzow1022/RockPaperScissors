using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RPSLS
{
    class Game
    {
        // member 
        Player playerOne;
        Player playerTwo;
        string determinePlayerTwo;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        // ctor
        public Game()
        {
            playerOne = new Player();
        }

        //member methods

        public void DeterminePlayerTwo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How do you want to play? Please enter the number for your choice.");
            Console.WriteLine("1. Human vs. Human");
            Console.WriteLine("2. Human vs Computer");
            determinePlayerTwo = Console.ReadLine();

            if (determinePlayerTwo == "1")
            {
                playerTwo = new Human();
            }
            else if (determinePlayerTwo == "2")
            {
                playerTwo = new Computer();
            }
            else
            {
                Console.WriteLine("You have entered an invalid option. Please try again.");
                DeterminePlayerTwo();
            }
        }

        public void gameInstructions()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Rules for Rock, Paper, Scissors, Lizard, Spock:");
            Console.WriteLine("- Scissors cuts Paper");
            Console.WriteLine("- Paper covers Rock");
            Console.WriteLine("- Rock crushes Lizard");
            Console.WriteLine("- Lizard poisons Spock");
            Console.WriteLine("- Spock smashes Scissors");
            Console.WriteLine("- Scissors decapitates Lizard");
            Console.WriteLine("- Lizard eats Paper");
            Console.WriteLine("- Paper disproves Spock");
            Console.WriteLine("- Spock vaporizes Rock");
            Console.WriteLine("- Rock crushes Scissors");
            Console.WriteLine("Must win 2 out of 3 rounds to win the match.");
            Console.ResetColor();
            Console.WriteLine("\n" + "--Press enter to begin--");
        }

        public void playGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerOne.name + ", what is your choice?");
            playerOne.GetChoice();
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(playerTwo.name + ", what is your choice?");
            playerTwo.GetChoice();
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerOne.name + " chose " + playerOne.ToChoice() + ".");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(playerTwo.name + " chose " + playerTwo.ToChoice() + ".");
            Console.ResetColor();


            if ((playerOne.playerChoice == "3" | playerTwo.playerChoice == "3") & (playerOne.playerChoice == "2" | playerTwo.playerChoice == "2"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Scissors cuts Paper");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "2" | playerTwo.playerChoice == "2") & (playerOne.playerChoice == "1" | playerTwo.playerChoice == "1"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Paper covers Rock");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "1" | playerTwo.playerChoice == "1") & (playerOne.playerChoice == "4" | playerTwo.playerChoice == "4"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Rock crushes Lizard");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "4" | playerTwo.playerChoice == "4") & (playerOne.playerChoice == "5" | playerTwo.playerChoice == "5"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Lizard poisons Spock");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "5" | playerTwo.playerChoice == "5") & (playerOne.playerChoice == "3" | playerTwo.playerChoice == "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Spock smashes Scissors");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "3" | playerTwo.playerChoice == "3") & (playerOne.playerChoice == "4" | playerTwo.playerChoice == "4"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Scissors decapitates Lizard");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "4" | playerTwo.playerChoice == "4") & (playerOne.playerChoice == "2" | playerTwo.playerChoice == "2"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Lizard eats Paper");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "2" | playerTwo.playerChoice == "2") & (playerOne.playerChoice == "5" | playerTwo.playerChoice == "5"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Paper disproves Spock");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "5" | playerTwo.playerChoice == "5") & (playerOne.playerChoice == "1" | playerTwo.playerChoice == "1"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Spock vaporizes Rock");
                Console.ResetColor();
            }
            else if ((playerOne.playerChoice == "1" | playerTwo.playerChoice == "1") & (playerOne.playerChoice == "3" | playerTwo.playerChoice == "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + "Rock crushes Scissors");
                Console.ResetColor();
            }
            else if (playerOne.playerChoice == playerTwo.playerChoice)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n" + "You both picked the same option - no points awarded this round.");
                Console.ResetColor();
            }



            if (playerOne.playerChoice == "1" & (playerTwo.playerChoice == "3" | playerTwo.playerChoice == "4"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerOne.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "2" & (playerTwo.playerChoice == "1" | playerTwo.playerChoice == "5"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "3" & (playerTwo.playerChoice == "4" | playerTwo.playerChoice == "2"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "4" & (playerTwo.playerChoice == "5" | playerTwo.playerChoice == "2"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "5" & (playerTwo.playerChoice == "3" | playerTwo.playerChoice == "1"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == playerTwo.playerChoice)
            {
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n" + playerTwo.name + " won this round.");
                Console.ResetColor();
                Console.WriteLine("\n" + "--Press enter to continue--");
                Console.ReadLine();
                playerTwoScore++;
            }
        }

        public void GameSetUp()
        {
            DeterminePlayerTwo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player One");
            playerOne.GetName();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player Two");
            playerTwo.GetName();
            Console.ResetColor();
            Console.Clear();
            gameInstructions();
            Console.ReadLine();
        }

        public void matchWinner()
        {
            Console.Clear();
            if (playerOneScore == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + "    " + playerOne.name + " won the match!" + "\n");
                celebration();
            }
            else if (playerTwoScore == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n" + "    " + playerTwo.name + " won the match!" + "\n");
                celebration();
            }
        }


        public void celebration()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ´´´´´´´´´´´´´´´´´´´´´´´¶¶¶¶¶¶¶¶");
            Console.WriteLine("´´´´´´¶¶¶¶¶´´´´´´´´¶¶¶¶´´´´´´´´¶¶¶¶");
            Console.WriteLine("´´´´´¶´´´´´¶´´´´¶¶´´´´´´´´´´´´´´´´´´¶¶");
            Console.WriteLine("´´´´´¶´´´´´¶´´´¶¶´´´´´´¶¶´´´´¶¶´´´´´´´¶¶");
            Console.WriteLine("´´´´´¶´´´´¶´´¶¶´´´´´´´´¶¶´´´´¶¶´´´´´´´´¶¶");
            Console.WriteLine("´´´´´´¶´´´¶´´´¶´´´´´´´´´´´´´´´´´´´´´´´´´¶¶");
            Console.WriteLine("´´´´¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´´´´´´´´´´¶¶");
            Console.WriteLine("´´´¶´´´´´´´´´´´´¶´´´¶¶´´´´´´´´´´´¶¶´´´´´´¶¶");
            Console.WriteLine("´´¶¶´´´´´´´´´´´´¶´´´¶¶´´´´´´´´´´´¶¶´´´´´´¶¶");
            Console.WriteLine("´¶¶´´´¶¶¶¶¶¶¶¶¶¶¶´´´´´¶¶´´´´´´´¶¶´´´´´´´¶¶");
            Console.WriteLine("´¶´´´´´´´´´´´´´´´¶´´´´´´¶¶¶¶¶¶¶´´´´´´´´¶¶");
            Console.WriteLine("´¶¶´´´´´´´´´´´´´´¶´´´´´´´´´´´´´´´´´´´´¶¶");
            Console.WriteLine("´´¶´´´¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´´´´¶¶");
            Console.WriteLine("´´¶¶´´´´´´´´´´´¶´´´¶¶¶¶´´´´´´´´´¶¶¶¶");
            Console.WriteLine("´´´¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´¶¶¶¶¶¶¶¶¶");
 
        }
    }
}

