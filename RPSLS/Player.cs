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
        //ctor

        //member methods
        public void getName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
        }
    }
}
