using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class EdgeManager
    {
        private Edge[] Edges;
        private int NumOfEdges;

        public EdgeManager()
        {
            NumOfEdges = (2 * Game.Length * Game.Width) - Game.Length - Game.Width;
            InitializeEdgeArray();
        }

        private void InitializeEdgeArray()
        {
            Edges = new Edge[NumOfEdges];
            for (int i = 0; i < NumOfEdges; i++)
            {
                Edges[i] = new Edge(i);
            }
        }

    }
}
