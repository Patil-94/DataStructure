using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
public  class Node
    {
        public int data; //i have define two elements overthere
        public Node next;

      //constructor
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
