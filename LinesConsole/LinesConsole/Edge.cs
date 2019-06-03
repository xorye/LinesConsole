using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Edge
    {
        private Coordinate Source, Dest;

        public Edge(Coordinate[] coordinates)
        {   
            CheckValidEdge(coordinates);
            Source = coordinates[0];
            Dest = coordinates[0];
        }

        public Edge(int edgeID)
            :this(ConvertIDToCoordinates(edgeID))
        {
            
        }

        private static Coordinate[] ConvertIDToCoordinates(int id)
        {
            Coordinate[] result = new Coordinate[2];

            // TODO
            // Implement the conversion

            return result;
        }

        /// <summary>
        /// Checks the validity of an edge by checking if the given nodes are
        /// adjacent to each other.
        /// </summary>
        private void CheckValidEdge(Coordinate[] coordinates)
        {
            if (coordinates.Length != 2)
            {
                throw new InvalidEdgeException();
            }
        }
    }

}
