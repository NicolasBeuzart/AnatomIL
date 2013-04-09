using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Methode
    {
        public string name;

        public void Execute(string []args)
        {

        }
    }

    public class add : Methode
    {
        string _name;

        public add()
        {
            Name = "add";
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public void Execute(string []args)
        {

        }

    }
}
