using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    /// <summary>
    /// Circular linked list to manage the turn orders for the players
    /// </summary>
    class PlayerList
    {
        private Player head;
        private Player tail;
        private int count;

        public PlayerList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void AddPlayer(Player player)
        {

            if (head == null && tail == null)
            {
                head = player;
            }
            else
            {
                tail.SetNextPlayer(player);
            }
            tail = player;
            tail.SetNextPlayer(head);
            count++;
        }

        public int Count()
        {
            return count;
        }

    }
}
