using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables
        public string name;
        public string playerChoice;
        public string choice;

        //ctor
        public Player()
        {

        }

        //member methods
        public virtual void GetName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
        }

        public virtual string GetChoice()
        {
            
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");
            Console.WriteLine("4 - Lizard");
            Console.WriteLine("5 - Spock");
            playerChoice = Console.ReadLine();
            if (playerChoice != "1" & playerChoice != "2" & playerChoice != "3" & playerChoice != "4" & playerChoice != "5")
            {
                Console.WriteLine("You have entered an invalid option, Please try again.");
                GetChoice();
            }


            return playerChoice;
        }


        public virtual string ToChoice()
        {
            if (playerChoice == "1")
            {
               choice = "Rock";
            }
            else if (playerChoice == "2")
            {
                choice = "Paper";
            }
            else if (playerChoice == "3")
            {
                choice = "Scissors";
            }
            else if (playerChoice == "4")
            {
                choice = "Lizard";
            }
            else if (playerChoice == "5")
            {
                 choice = "Spock";
            }
            return choice;
        }
    }
}
