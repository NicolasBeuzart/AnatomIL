using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AnatomIL.test
{
    [TestFixture]
    public class AnatomilTest
    {
        [Test]
        public void TestForLybrary()
        {
            var lib = new Library();
            Methode newmethode = new add();
            Assert.That(lib.IsMethodeExiste("toto"), Is.False);
            newmethode.name = "add";

            Assert.That(newmethode.name, Is.EqualTo("add"));


        }
    }
}
