using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Stack
    {
        private List<StackItem> _currentstack = new List<StackItem>();

        public StackItem Pop()  // Return first element from stack and delete it from stack
        {
            StackItem tmp;

            if (_currentstack.Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }
            tmp = _currentstack[_currentstack.Count - 1];

            _currentstack.Remove(tmp);

            return tmp;
        }

        public List<StackItem> CurrentStack
        {
            get { return _currentstack; }
        }

        public void Push(Type t, object value) // Add 1 element on stack
        {
            StackItem elt = new StackItem(t, value);
            _currentstack.Add(elt);
        }

        public StackItem FirstElement()
        {
            if (_currentstack.Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }
            return (_currentstack[_currentstack.Count - 1]);
        }

        public bool IsEmpty
        {
            get { return (this.Count == 0); }
        }

        public int Count  // Return number of elements in stack
        {
            get
            {
                return _currentstack.Count;
            }
        }


    }
}
