using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables
        public string playerOne;
        public string playerTwo;
        string rock;
        string scissors;
        string lizard;
        string paper;
        string spock;
        // ctor

        //member methods


        public void playGame()
        {
            if (playerOne == rock & (playerTwo == scissors | playerTwo == lizard))
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne == paper & (playerTwo == paper | playerTwo == spock))
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne == scissors & (playerTwo == lizard | playerTwo == paper))
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne == lizard & (playerTwo == spock | playerTwo == paper))
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne == spock & (playerTwo == scissors | playerTwo == rock))
            {
                Console.WriteLine("Player One Wins");
            }
            else
            {
                Console.WriteLine("Player Two Wins");
            }
        }

        public void keepScore()
        {

        }
    }
}
