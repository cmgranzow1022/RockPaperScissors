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
            Console.WriteLine("Select 1 to choose Rock.");
            Console.WriteLine("Select 2 to choose Paper.");
            Console.WriteLine("Select 3 to choose Scissors.");
            Console.WriteLine("Select 4 to choose Lizard.");
            Console.WriteLine("Select 5 to choose Spock.");
            playerChoice = Console.ReadLine();

            return playerChoice;
        }
    }
}
