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

            Methode methode = lib.FindMethode("sub");
            Assert.That(methode.Name, Is.EqualTo("sub"));
            sub test = new sub();
            
            Assert.That(methode.GetType(), Is.EqualTo(test.GetType()));

        }

        [Test]
        public void TestForParser()
        {
            parser p = new parser();

            // simulation de code rentré par l'utilisateur
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
            
            // on verifi que les méthodes on bien était ajouter a la library
            Methode m = p.Lib.FindMethode("add");
            Assert.That(m.Name, Is.EqualTo("add"), "Méthode add inéxistant ou mal nomé");

            m = p.Lib.FindMethode("sub");
            Assert.That(m.Name, Is.EqualTo("sub"), "Méthode sub inéxistant ou mal nomé");

            m = p.Lib.FindMethode("mul");
            Assert.That(m.Name, Is.EqualTo("mul"), "Méthode mul inéxistant ou mal nomé");

            m = p.Lib.FindMethode("div");
            Assert.That(m.Name, Is.EqualTo("div"), "Méthode div inéxistant ou mal nomé");

            m = p.Lib.FindMethode("rem");
            Assert.That(m.Name, Is.EqualTo("rem"), "Méthode rem inéxistant ou mal nomé");

            m = p.Lib.FindMethode("ldc");
            Assert.That(m.Name, Is.EqualTo("ldc"), "Méthode ldc inéxistant ou mal nomé");

            p.Code.Instructions = s;

            // Executions des instructions

            // ldc.i4.13
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1), "Probleme a l'éxécution de l'instruction ldc.i4.13");
            Assert.That(p.s.FirstElement(), Is.EqualTo(13), "Probleme a l'éxécution de l'instruction ldc.i4.13");

            //ldc.i4.12
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction ldc.i4.12");
            Assert.That(p.s.FirstElement(), Is.EqualTo(12), "Probleme a l'éxécution de l'instruction ldc.i4.12");

            //add
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1), "Probleme a l'éxécution de l'instruction add");
            Assert.That(p.s.FirstElement(), Is.EqualTo(25), "Probleme a l'éxécution de l'instruction add");

            //ldc.i4.30
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction ldc.i4.30");
            Assert.That(p.s.FirstElement(), Is.EqualTo(30), "Probleme a l'éxécution de l'instruction ldc.i4.30");

            //sub
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1), "Probleme a l'éxécution de l'instruction sub");
            Assert.That(p.s.FirstElement(), Is.EqualTo(5), "Probleme a l'éxécution de l'instruction sub");

            //ldc.i4.20
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction ldc.i4.20");
            Assert.That(p.s.FirstElement(), Is.EqualTo(20), "Probleme a l'éxécution de l'instruction ldc.i4.20");

            //div
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(1), "Probleme a l'éxécution de l'instruction div");
            Assert.That(p.s.FirstElement(), Is.EqualTo(4), "Probleme a l'éxécution de l'instruction div");

            //ldc.i4.5
            p.ExecuteNextInstruction();
            Assert.That(p.s.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction ldc.i4.5");
            Assert.That(p.s.FirstElement(), Is.EqualTo(5), "Probleme a l'éxécution de l'instruction ldc.i4.5");

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
