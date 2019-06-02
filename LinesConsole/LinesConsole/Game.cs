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
        private Boolean IsFinished;

        public Game(int numPlayers, int width, int height)
        {
            NumPlayers = numPlayers;
            Width = width;
            Height = height;
            IsFinished = false;

            PrintWelcomeMessage();

            Board = new GameBoard(Width, Height);
            PlayerManager = new PlayerManager();
            AddPlayersToGame();

            StartGameLoop();

        }

        private void StartGameLoop()
        {
            Console.WriteLine("The game will begin...");

            while (!IsFinished)
            {

            }
        }

        private void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to...");
            Console.WriteLine("  _      _                 ");
            Console.WriteLine(" | |    (_)                ");
            Console.WriteLine(" | |     _ _ __   ___  ___ ");
            Console.WriteLine(" | |    | | '_ \\ / _ \\/ __|");
            Console.WriteLine(" | |____| | | | |  __/\\__ \\");
            Console.WriteLine(" |______|_|_| |_|\\___||___/");
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
                i++;
            }
        }
    }
}
