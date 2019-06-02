using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Game
    {

        private GameBoard board;


        public Game()
        {
            Console.WriteLine("Welcome to Lines!");
            Console.WriteLine("A 9 by 9 board will be generated!");

            
        }

        private void InitializeGameBoard(int length, int width)
        {
            board = new GameBoard(length, width);
        }
    }
}
