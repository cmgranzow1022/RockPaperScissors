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
            
            Console.WriteLine("1 to choose Rock.");
            Console.WriteLine("2 to choose Paper.");
            Console.WriteLine("3 to choose Scissors.");
            Console.WriteLine("4 to choose Lizard.");
            Console.WriteLine("5 to choose Spock.");
            playerChoice = Console.ReadLine();
            if (playerChoice != "1" & playerChoice != "2" & playerChoice != "3" & playerChoice != "4" & playerChoice != "5")
            {
                Console.WriteLine("You have entered an invalid option, Please try again.");
                GetChoice();
            }
            return playerChoice;
        }
    }
}
