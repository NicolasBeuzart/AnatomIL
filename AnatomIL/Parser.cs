using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class parser
    {
        int _pc;
        Library _lib;
        Methode _methode;

        public void Initialisation()
        {
            var temp1 = new add();
            temp1.Name = "add";
            _lib.AddMethode(temp1);

            var temp2 = new sub();
            temp2.Name = "sub";
            _lib.AddMethode(temp2);

            var temp3 = new mul();
            temp3.Name = "mul";
            _lib.AddMethode(temp3);

            var temp4 = new div();
            temp4.Name = "div";
            _lib.AddMethode(temp4);

            var temp5 = new rem();
            temp5.Name = "div";
            _lib.AddMethode(temp5);
        }

    }
}
