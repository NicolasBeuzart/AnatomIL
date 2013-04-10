using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Stack
    {
        private Node first = null;
        private int nbr_elt = 0;


        public object Pop()  // Return first element from stack and delete it from stack
        {
            if (first == null)
            {
                throw new InvalidOperationException("Empty Stack");
            }
            else
            {
                object tmp = first.Value;
                first = first.Next;
                nbr_elt--;
                return tmp;
            }
        }

        public object FirstElement()  // Return first element from stack
        {
            if (first == null)
            {
                throw new InvalidOperationException("Empty Stack");
            }
            else
            {
                return first.Value;
            }
        }

        public void Push(object elt) // Add 1  on stack
        {
            first = new Node(elt, first);
            nbr_elt++;
        }

        public bool IsEmpty  // Return TRUE if the stack is empty, else FALSE
        {
            get
            {
                return (first == null);
            }
        }

        public int Count  // Return number of elements in stack
        {
            get
            {
                return nbr_elt;
            }
        }

    }
}
