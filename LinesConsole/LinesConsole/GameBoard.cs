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
        private Square[,] SquareMatrix;
        private EdgeManager EdgeSet;

        public GameBoard()
        {
            EdgeSet = new EdgeManager();
            InitializeNodeArray();   
        }

        /// <summary>
        /// Prints the current board state
        /// </summary>
        public void PrintBoard()
        {

            StringBuilder sb = new StringBuilder();

            
        }

        /// <summary>
        /// Appends the row where horizontal edges can lie
        /// </summary>
        /// <param name="row"></param>
        /// <param name="sb"></param>
        private void AppendNodeRow(int row, StringBuilder sb)
        {
            for (int i = 0; i < Game.Length - 1; i++)
            {
                sb.Append("+");
                // Here, determine if horizontal edge should exist
                // If it should exist, append edge, else append space
                sb.Append("   ");
            }
            sb.Append("+");
        }

        /// <summary>
        /// Appends the row where vertical edges can lie
        /// </summary>
        /// <param name="row"></param>
        /// <param name="sb"></param>
        private void AppendEdgeRow(int row, StringBuilder sb)
        {
            for (int i = 0; i < Game.Length - 1; i++)
            {
                // Here, determine if vertical edge should exist
                // If it should exist, append edge, else append space
                sb.Append(" ");

                // Here, determine if the current square has been 
            }
        }



        private void InitializeNodeArray()
        {
            SquareMatrix = new Square[Game.Width - 1, Game.Length - 1];
            for (int i = 0; i < Game.Width - 1; i++)
            {
                for (int j = 0; j < Game.Length - 1; j++)
                {
                    SquareMatrix[i, j] = new Square(i, j);
                }
            }

        }

        private int GetNumberOfNodes()
        {
            return Game.Length * Game.Width;
        }


    }
}
