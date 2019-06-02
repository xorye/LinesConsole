using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class InvalidEdgeException : Exception
    {

        public InvalidEdgeException()
        {
        }

        public InvalidEdgeException(string message)
            : base(message)
        {
        }

        public InvalidEdgeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}
