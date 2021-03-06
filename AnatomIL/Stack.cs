﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Stack
    {
        private List<StackItem> _currentstack = new List<StackItem>();


        public bool Pop(out StackItemValue StV)  // Return first element from stack and delete it from stack
        {
            StackItem tmp;
            StV = null;

            if (_currentstack.Count == 0)
            {
                return(false);
            }

            tmp = _currentstack[_currentstack.Count - 1];

            if (tmp is StackItemFrame)
            {
                return (false);
            }
            else if (tmp is StackItemValue)
            {
                StV = new StackItemValue(tmp.Type, tmp.Value);
                _currentstack.Remove(tmp);
                return (true);
            }
            return (false);
        }

        public List<StackItem> CurrentStack
        {
            get { return _currentstack; }
        }

        public void Push(Type t, object value) // Add 1 element on stack
        {
            StackItemValue elt = new StackItemValue(t, value);
            _currentstack.Add(elt);
        }

        public void PushFrame(List<StackItemValue> args, List<StackItemValue> vars, Type rt, string name)
        {
            _currentstack.Add(new StackItemFrame(args, vars, rt, name));
        }

        public bool PopFrame()
        {
            StackItem tmp;

            if (_currentstack.Count == 0)
            {
                return (false);
            }

            tmp = _currentstack[_currentstack.Count - 1];

            if (tmp is StackItemFrame)
            {
                _currentstack.Remove(tmp);
                return (true);
            }
            else if (tmp is StackItemValue)
            {
                return (false);
            }
            return (false);
        }

        public bool FirstElement(out StackItemValue StV)
        {
            StV = null;

            if (_currentstack.Count == 0)
            {
                return false;
            }
            if (_currentstack[_currentstack.Count - 1] is StackItemValue)
            {
                StV = new StackItemValue(_currentstack[_currentstack.Count - 1].Type, _currentstack[_currentstack.Count - 1].Value);
                return true;
            }
            else
            {
                return false;
            }
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

        public StackItemFrame CurentStackItemFrame()
        {
            int i;
            StackItemFrame s = null;

            for (i = _currentstack.Count - 1; _currentstack[i].Type != typeof(StackItemFrame); i--)
            {
                
            }
            s = _currentstack[i].Convert();
            return s;
        }

    }
}
