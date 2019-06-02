using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Player
    {

        private String name;
        private int score;
        private Player nextPlayer;

        public Player(String name)
        {
            this.name = name;
            this.score = 0;
            this.nextPlayer = null;
        }

        public Edge GetMove()
        {
            // get source and dest node from user input
            int source = 2;
            int dest = 6;
            return new Edge(source, dest);
        }

        public void SetNextPlayer(Player player)
        {
            nextPlayer = player;
        }

        public Player GetNextPlayer()
        {
            return nextPlayer;
        }
    }
}
