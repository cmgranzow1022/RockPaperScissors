using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables
        Random rnd = new Random();
        public int randomInt;

        //ctor
        public Computer()
        {
  
        }

        //member methods
        public override void GetName()
        {
             name = "Walter";
            Console.WriteLine(name);
        }

        public override string GetChoice()
        {
            randomInt = rnd.Next(1, 6);
            playerChoice = Convert.ToString(randomInt);
            Console.WriteLine(playerChoice);

            return playerChoice;
         }


    }
}

