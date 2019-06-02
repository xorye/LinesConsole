using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class GameBoard
    {
        private int length, width;
        private Node[] nodes;

        public GameBoard(int length, int width)
        {
            this.length = length;
            this.width = width;
            InitializeNodeArray();

            
        }

        private void InitializeNodeArray()
        {
            nodes = new Node[GetNumberOfNodes()];
            for (int i = 0; i < GetNumberOfNodes(); i++)
            {
                nodes[i] = new Node(i);    
            }

        }

        private int GetNumberOfNodes()
        {
            return length * width;
        }


    }
}
