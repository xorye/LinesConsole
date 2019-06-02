using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Edge
    {
        private int Source, Dest;

        public Edge(int source, int dest)
        {
            CheckValidEdge();
            this.Source = source;
            this.Dest = dest;
        }

        public Edge(int[] edges)
            : this(edges[0], edges[1])
        {
        }

        /// <summary>
        /// Checks the validity of an edge by checking if the given nodes are
        /// adjacent to each other.
        /// </summary>
        private void CheckValidEdge(int source, int dest)
        {
            return;
        }
    }

}
