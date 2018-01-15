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
        //string userInput;



        // ctor
        public Game()
        { 
            playerOne = new Player();
        }

        //member methods

    

        public void DeterminePlayerTwo()
        {
            Console.WriteLine("Will player two be a human, or do you want to play against a computer? Please enter the number for your choice.");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Computer");
            determinePlayerTwo = Console.ReadLine();

            if (determinePlayerTwo == "1")
            {
                    playerTwo = new Human();
            }
            else if(determinePlayerTwo == "2")
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
            Console.WriteLine("Press enter to begin");
            
        }

        public void playGame()
        {
            Console.Clear();
            Console.WriteLine(playerOne.name + ", what is your choice?");
            playerOne.GetChoice();
            Console.Clear();
            Console.WriteLine(playerTwo.name + ", what is your choice?");
            playerTwo.GetChoice();

            Console.WriteLine(playerOne.name + " chose " + playerOne.playerChoice + ".");
            Console.WriteLine(playerTwo.name + " chose " + playerTwo.playerChoice + ".");

            if (playerOne.playerChoice == "1" & (playerTwo.playerChoice == "3" | playerTwo.playerChoice == "4"))
            {
                Console.WriteLine(playerOne.name + " won this round.");
                Console.ReadLine();
                playerOneScore++; 
            }
            else if (playerOne.playerChoice == "2" & (playerTwo.playerChoice == "1" | playerTwo.playerChoice == "5"))
            {
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "3" & (playerTwo.playerChoice == "4" | playerTwo.playerChoice == "2"))
            {
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "4" & (playerTwo.playerChoice == "5"  | playerTwo.playerChoice == "2"))
            {
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == "5" & (playerTwo.playerChoice == "3" | playerTwo.playerChoice == "1"))
            {
                Console.WriteLine("\n" + playerOne.name + " won this round.");
                Console.ReadLine();
                playerOneScore++;
            }
            else if (playerOne.playerChoice == playerTwo.playerChoice)
            {
                Console.WriteLine("\n" + "It's a tie! ");
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("\n" + playerTwo.name + " won this round.");
                Console.ReadLine();
                playerTwoScore++;
            }

        }

          public void GameSetUp()
        {
            DeterminePlayerTwo();
            Console.WriteLine("Player One");
            playerOne.GetName();
            Console.WriteLine("Player Two");
            playerTwo.GetName();
 
            gameInstructions();
            Console.ReadLine();

        }

        public void matchWinner()
        {
          if( playerOneScore == 2)
            {
                Console.WriteLine(playerOne.name + " won the match!");
            }
            else if(playerTwoScore == 2)
            {
                Console.WriteLine(playerTwo.name + " won the match!");
            }
        }


        }
    }

