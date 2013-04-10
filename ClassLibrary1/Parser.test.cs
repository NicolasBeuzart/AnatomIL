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
            var sub = new sub();
            string[] s = new string[1];
            Assert.That(lib.IsMethodeExiste("toto"), Is.False);
            newmethode.Name = "add";
            Assert.That(sub.Name, Is.EqualTo("sub"));
            Assert.That(newmethode.Name, Is.EqualTo("add"));
            lib.AddMethode(new add());
            lib.AddMethode(new sub());
            Assert.That(lib.IsMethodeExiste("add"), Is.True);
            //Assert.That(lib.FindMethode("add"), Is.SameAs(newmethode));

            Methode methode = lib.FindMethode("sub");
            Assert.That(methode.Name, Is.EqualTo("sub"));
            sub test = new sub();
            
            //Assert.That(test.Name, Is.EqualTo("good"));

            Assert.That(methode.GetType(), Is.EqualTo(test.GetType()));


           // Assert.That(methode.Name, Is.EqualTo("good"));
        }

        [Test]
        public void TestForParser()
        {
            parser p = new parser();
            string[] s = new string[3];

            s[0] = "ldc.i4.13";
            s[1] = "ldc.i4.12";
            s[2] = "add";
            Methode m = p.Lib.FindMethode("add");
            Assert.That(m.Name, Is.EqualTo("add"));

            m = p.Lib.FindMethode("sub");
            Assert.That(m.Name, Is.EqualTo("sub"));

            m = p.Lib.FindMethode("mul");
            Assert.That(m.Name, Is.EqualTo("mul"));

            m = p.Lib.FindMethode("div");
            Assert.That(m.Name, Is.EqualTo("div"));

            m = p.Lib.FindMethode("rem");
            Assert.That(m.Name, Is.EqualTo("rem"));
            m = p.Lib.FindMethode("ldc");
            Assert.That(m.Name, Is.EqualTo("ldc"));
            p.Code.Instructions = s;
            string[] s2 = s[0].Split('.');
            Assert.That(s2[0], Is.EqualTo("ldc"));
            Assert.That(s2[1], Is.EqualTo("i4"));
            Assert.That(Convert.ToInt32(s2[2]), Is.EqualTo(13));

            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            p.ExecuteNextInstruction();
            //p.Lib.FindMethode("sub").Name = "good";
            Assert.That(p.s.Count, Is.EqualTo(1));
        }
        

    }
}
