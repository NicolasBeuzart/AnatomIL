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
            string[] s = new string[11];

            s[0] = "ldc.i4.13";
            s[1] = "ldc.i4.12";
            s[2] = "add";
            s[3] = "ldc.i4.30";
            s[4] = "sub";
            s[5] = "ldc.i4.20";
            s[6] = "div";
            s[7] = "ldc.i4.5";
            s[8] = "mul";
            s[9] = "ldc.i4.25";
            s[10] = "rem";
            
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

            // ldc.i4.13
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(13));

            //ldc.i4.12
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            Assert.That(p.s.FirstElement(), Is.EqualTo(12));

            //add
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(25));

            //ldc.i4.30
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            Assert.That(p.s.FirstElement(), Is.EqualTo(30));

            //sub
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(5));

            //ldc.i4.20
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            Assert.That(p.s.FirstElement(), Is.EqualTo(20));

            //div
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(4));

            //ldc.i4.5
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            Assert.That(p.s.FirstElement(), Is.EqualTo(5));

            //mull
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(20));

            //ldc.i4.5
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2));
            Assert.That(p.s.FirstElement(), Is.EqualTo(25));

            //rem
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1));
            Assert.That(p.s.FirstElement(), Is.EqualTo(5));
        }
        

    }
}
