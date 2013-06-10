using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnatomIL
{
    public class EnumManagementSample
    {
        public void Initialize()
        {
            Compiler c = new Compiler();
            c.EnumManager.Register(typeof(KnownColor), "Color");
        }
    }
}
