using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Node
    {
        private int node_num;
        private int up, down, left, right;


        public Node(int node_num)
        {
            this.node_num = node_num;
            this.up = Program.NO_NODE;
            this.down = Program.NO_NODE;
            this.left = Program.NO_NODE;
            this.right = Program.NO_NODE;
        }
    }
}
