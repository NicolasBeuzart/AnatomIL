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
            var newmethode = new add();
            Assert.That(lib.IsMethodeExiste("toto"), Is.False);
            newmethode.Name = "add";

            Assert.That(newmethode.Name, Is.EqualTo("add"));
            lib.AddMethode(newmethode);

            Assert.That(lib.IsMethodeExiste("add"), Is.True);
            Assert.That(lib.FindMethode("add"), Is.SameAs(newmethode));

            var methode = lib.FindMethode("add");
            newmethode.Execute();
            Assert.That(methode.Name, Is.EqualTo("lol"));
        }

        [Test]
        public void TestForParser()
        {
            parser p = new parser();
        }
        

    }
}
