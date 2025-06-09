using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Node
    {
        //info represents data
        public int info;

        //link is of type node and refers to the next node
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
