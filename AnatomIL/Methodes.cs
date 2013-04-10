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

        public void Execute(string[] args) { this.Name = "bad"; }
    }

    public class add : Methode
    {

        public add()
        {
            this.Name = "add";
        }

        new public void Execute(string[] args)
        {
            this.Name = "good";
        }
    }

    public class sub : Methode
    {

        public sub()
        {
            this.Name = "sub";
        }

        new public void Execute(string[] args)
        {
            this.Name = "good";
        }
    }

    public class mul : Methode
    {

        public mul()
        {
            this.Name = "mul";
        }

        new public void Execute(string[] args)
        {
            this.Name = "lol";
        }
    }

    public class div : Methode
    {

        public div()
        {
            this.Name = "div";
        }

        new public void Execute(string[] args)
        {
            this.Name = "lol";
        }
    }

    public class rem : Methode
    {

        public rem()
        {
            this.Name = "rem";
        }

        new public void Execute(string[] args)
        {
            this.Name = "lol";
        }
    }


}
