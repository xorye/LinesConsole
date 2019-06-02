using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Game
    {

        private GameBoard Board;
        private PlayerManager PlayerManager;
        private int NumPlayers, Width, Height;


        public Game(int numPlayers, int width, int height)
        {
            NumPlayers = numPlayers;
            Width = width;
            Height = height;

            Console.WriteLine("Welcome to Lines!");
            Console.WriteLine("A 9 by 9 board will be generated!");
            Board = new GameBoard(Width, Height);
            PlayerManager = new PlayerManager();

            AddPlayersToGame();

        }

        /// <summary>
        /// Add NumPlayers players to the game
        /// </summary>
        /// <param name="numPlayers"></param>
        private void AddPlayersToGame()
        {
            int i = 0;

            while (i < NumPlayers)
            {
                PlayerManager.AddPlayer(UserInput.GetPlayerName());
            }
        }
    }
}
