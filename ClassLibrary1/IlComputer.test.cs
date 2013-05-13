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
            Library lib = new Library();
            lib.LoadInstructionLib();

            // on test la methode LibIsOpCodeRootExiste
            Assert.That(lib.LibIsCodeOpRootExiste("toto"), Is.False);
            Assert.That(lib.LibIsCodeOpRootExiste("add"), Is.True);

            OpCodeRoot operation = lib.LibFindOpCodeRoot("sub");

            // on test qu'un CodeOpRoot est crée correctement
            Assert.That(operation.Name, Is.EqualTo("sub"));
            Assert.That(operation.GetType(), Is.EqualTo(typeof(SubCodeOpRoot)));
        }

        [Test]
        public void TestForcompiler()
        {
            Compiler c = new Compiler();
            CompilerResult result;
            string[] s = new string[1];
            s[0] = "   ldc.i4 13    ";

            result = c.Compile(s);
            Assert.That(result.IsSuccess, Is.True);

            s[0] = "lda.i4.13";
            result = c.Compile(s);
            Assert.That(result.IsSuccess, Is.False);
        }


        [Test]
        public void TestForParser()
        {
            IlComputer p = new IlComputer();

            // simulation de code rentré par l'utilisateur
            string[] s = new string[11];
            s[0] = "ldc.i4 13";
            s[1] = "ldc.i4 12";
            s[2] = "add";
            s[3] = "ldc.i4 30";
            s[4] = "sub";
            s[5] = "ldc.i4 20";
            s[6] = "div";
            s[7] = "ldc.i4 5";
            s[8] = "mul";
            s[9] = "ldc.i4 25";
            s[10] = "rem";
            
            // on verifi que les méthodes on bien était ajouter a la library

            p.LoadCode(s);
            p.compile();
            p.Start();

            // Executions des instructions

            // ldc.i4.13
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction ldc.i4 13");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(13), "Probleme a l'éxécution de l'instruction ldc.i4 13");

            //ldc.i4.12
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(3), "Probleme a l'éxécution de l'instruction ldc.i4.12");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(12), "Probleme a l'éxécution de l'instruction ldc.i4.12");

            //add
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction add");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(25), "Probleme a l'éxécution de l'instruction add");

            //ldc.i4.30
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(3), "Probleme a l'éxécution de l'instruction ldc.i4.30");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(30), "Probleme a l'éxécution de l'instruction ldc.i4.30");

            //sub
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction sub");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(5), "Probleme a l'éxécution de l'instruction sub");

            //ldc.i4.20
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(3), "Probleme a l'éxécution de l'instruction ldc.i4.20");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(20), "Probleme a l'éxécution de l'instruction ldc.i4.20");

            //div
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2), "Probleme a l'éxécution de l'instruction div");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(4), "Probleme a l'éxécution de l'instruction div");

            //ldc.i4.5
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(3), "Probleme a l'éxécution de l'instruction ldc.i4.5");
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(5), "Probleme a l'éxécution de l'instruction ldc.i4.5");

            //mull
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2));
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(20));

            //ldc.i4.5
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(3));
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(25));

            //rem
            p.ExecuteNextInstruction();
            Assert.That(p.Stack.Count, Is.EqualTo(2));
            Assert.That(p.Stack.CurrentStack[p.Stack.Count - 1].Value, Is.EqualTo(5));

            p.reset();

        }
        

    }
}
