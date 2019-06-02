using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Player
    {

        private String name;
        private int score;

        public Player(String name)
        {
            this.name = name;
            this.score = 0;
        }

        public Edge GetMove()
        {
            // get source and dest node from user input
            int source = 2;
            int dest = 6;
            return new Edge(source, dest);
        }
    }
}
