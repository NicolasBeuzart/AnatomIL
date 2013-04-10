using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    class Node
    {
        public Node Next;
        public object Value;

        public Node(object value)
              :this(value, null)
        {
        }

        public Node(object value, Node next)
        {
            Next = next;
            Value = value;
        }
    }
}
