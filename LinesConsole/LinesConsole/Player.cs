using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Player
    {

        private String Name;
        private char Marker;
        private int Score;
        private Player NextPlayer;

        public Player(String name, char marker)
        {
            Name = name;
            Marker = marker;
            Score = 0;
            NextPlayer = null;
        }

        public Edge GetMove()
        {
            // get source and dest node from user input
            return UserInput.GetEdge();
        }

        public void SetNextPlayer(Player player)
        {
            NextPlayer = player;
        }

        public Player GetNextPlayer()
        {
            return NextPlayer;
        }
    }
}
