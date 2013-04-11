using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Methode // classe "père" de toute les méthodes InstObjRoot
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

        virtual public void Execute(string[] args, Stack s) {  }
    }

    public class add : Methode
    {

        public add()
        {
            this.Name = "add";
        }

        override public void Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 + i2);
        }
    }

    public class sub : Methode
    {

        public sub()
        {
            this.Name = "sub";
        }

        override public void Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 - i2);
        }
    }

    public class mul : Methode
    {

        public mul()
        {
            this.Name = "mul";
        }

        override public void Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 * i2);
        }
    }

    public class div : Methode
    {

        public div()
        {
            this.Name = "div";
        }

        override public void Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 / i2);
        }
    }

    public class rem : Methode
    {

        public rem()
        {
            this.Name = "rem";
        }

        override public void Execute(string[] args, Stack s)
        {
            int i1 = Convert.ToInt32(s.Pop());
            int i2 = Convert.ToInt32(s.Pop());
            s.Push(i1 % i2);
        }
    }

    public class ldc : Methode
    {
        public ldc()
        {
            this.Name = "ldc";
        }

        override public void Execute(string[] args, Stack s)
        {
            if (args[1].Equals("i4"))
            {
                s.Push(Convert.ToInt32(args[2]));
            }
        }
    }


}
