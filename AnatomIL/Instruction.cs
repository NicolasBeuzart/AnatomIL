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

        public void Execute()
        {
        }
    }

    public class add : Methode
    {

        public void Execute()
        {
            base.Execute();
            this.Name = "lol";
        }
    }

    public class sub : Methode
    {

        public void Execute()
        {
            base.Execute();
            this.Name = "lol";
        }
    }

    public class mul : Methode
    {

        public void Execute()
        {
            base.Execute();
            this.Name = "lol";
        }
    }

    public class div : Methode
    {

        public void Execute()
        {
            base.Execute();
            this.Name = "lol";
        }
    }

    public class rem : Methode
    {

        public void Execute()
        {
            base.Execute();
            this.Name = "lol";
        }
    }
}
