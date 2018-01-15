using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();

            newGame.GameSetUp();
            while (newGame.playerOneScore < 2 & newGame.playerTwoScore < 2)
            {
                newGame.playGame();
            }

            newGame.matchWinner();
                newGame.playAgain();
        }
    }
}
