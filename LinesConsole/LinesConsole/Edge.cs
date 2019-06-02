using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Edge
    {
        int source, dest;

        public Edge(int source, int dest)
        {
            
            this.source = source;
            this.dest = dest;
        }

        public Edge(int[] edges)
            : this(edges[0], edges[1])
        {
        }

        /// <summary>
        /// Checks the validity of an edge by checking if the given nodes are
        /// adjacent to each other.
        /// </summary>
        private void CheckValidEdge()
        {

        }
    }

}
