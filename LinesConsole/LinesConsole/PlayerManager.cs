using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class PlayerManager
    {
        private PlayerList playerList;
        private Player currentPlayer;

        public PlayerManager()
        {
            playerList = new PlayerList();
        }

        public void AddPlayer(String name)
        {
            Player player = new Player(name);
            playerList.AddPlayer(player);

            if (GetNumberOfPlayers() == 1)
            {
                currentPlayer = player;
            }
        }

        public int GetNumberOfPlayers()
        {
            return playerList.Count();
        }

        
        public Edge CurrentPlayerMove()
        {
            return currentPlayer.GetMove();
        }


        // Updates the currentPlayer to the next player
        public void ChangeCurrentPlayer()
        {
            currentPlayer = currentPlayer.GetNextPlayer();
        }
    }
}
