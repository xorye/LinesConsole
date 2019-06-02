using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class GameBoard
    {
        private const String HORIZONTAL_EDGE = "---";
        private const String VERTICAL_EDGE = "|";
        private int Length, Width;
        private Node[] Nodes;
        private EdgeSet EdgeSet;

        public GameBoard(int length, int width)
        {
            Length = length;
            Width = width;
            EdgeSet = new EdgeSet();
            InitializeNodeArray();   
        }

        /// <summary>
        /// Prints the current board state
        /// </summary>
        public void PrintBoard()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sb.Append(".");
                    if (j != Width - 1)
                    {
                        sb.Append(" ");
                    }
                }
            }
        }

        private void InitializeNodeArray()
        {
            Nodes = new Node[GetNumberOfNodes()];
            for (int i = 0; i < GetNumberOfNodes(); i++)
            {
                Nodes[i] = new Node(i);    
            }

        }

        private int GetNumberOfNodes()
        {
            return Length * Width;
        }


    }
}
