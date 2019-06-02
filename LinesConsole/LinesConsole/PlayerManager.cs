using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class PlayerManager
    {
        private ArrayList playerList;
        private Player currentPlayer;

        public PlayerManager()
        {
            playerList = new ArrayList();
        }

        public void AddPlayer(String name)
        {
            Player player = new Player(name);
            playerList.Add(player);

            if (GetNumberOfPlayers() == 1)
            {
                currentPlayer = player;
            }
        }

        public int GetNumberOfPlayers()
        {
            return playerList.Count;
        }

        
        public Edge CurrentPlayerMove()
        {
            
        }


        // Updates the currentPlayer to the next player
        public void ChangeCurrentPlayer()
        {

        }
    }
}
