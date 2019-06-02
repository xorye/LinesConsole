using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesConsole
{
    class Node
    {
        private int node_num;
        private int up, down, left, right;


        public Node(int node_num)
        {
            this.node_num = node_num;
            this.up = Program.NULL_NODE;
            this.down = Program.NULL_NODE;
            this.left = Program.NULL_NODE;
            this.right = Program.NULL_NODE;
        }
    }
}
