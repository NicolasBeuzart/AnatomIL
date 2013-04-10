using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Methode
    {
        string _name;

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
            }
        }

        public Stack Execute(string[] args, Stack s) { this.Name = "bad"; return (s); }
    }

    public class add : Methode
    {

        public add()
        {
            this.Name = "add";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 + i2);
            return (s);
            
        }
    }

    public class sub : Methode
    {

        public sub()
        {
            this.Name = "sub";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            this.Name = "good";
            return (s);
        }
    }

    public class mul : Methode
    {

        public mul()
        {
            this.Name = "mul";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            this.Name = "lol";
            return (s);
        }
    }

    public class div : Methode
    {

        public div()
        {
            this.Name = "div";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            this.Name = "lol";
            return (s);
        }
    }

    public class rem : Methode
    {

        public rem()
        {
            this.Name = "rem";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            this.Name = "lol";
            return (s);
        }
    }

    public class ldc : Methode
    {
        public ldc()
        {
            this.Name = "ldc";
        }

        new public Stack Execute(string[] args, Stack s)
        {
            if (args[1].Equals("i4"))
            {
                s.Push(Convert.ToInt32(args[2]));
            }
            return (s);
        }
    }


}
