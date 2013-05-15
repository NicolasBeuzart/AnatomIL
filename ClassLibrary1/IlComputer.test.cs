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
            Assert.That(operation.GetType(), Is.EqualTo(typeof(SubOpCodeRoot)));
        }

        [Test]
        public void TestForcompiler()
        {
            Compiler c = new Compiler();
            CompilerResult result;
            string[] s = new string[1];
            s[0] = "   ldc.i4 13    ";


            result = c.Compile(new Tokeniser(s));
            Assert.That(result.IsSuccess, Is.False);

            s[0] = "lda.i4.13";
            result = c.Compile(new Tokeniser(s));
            Assert.That(result.IsSuccess, Is.False);
        }


        [Test]
        public void TestForParser()
        {
            IlComputer p = new IlComputer();

            // simulation de code rentré par l'utilisateur
            string[] s = new string[14];
            s[0] = "void main()";
            s[1] = "{";
            s[2] = "ldc.i4 13";
            s[3] = "ldc.i4 12";
            s[4] = "add";
            s[5] = "ldc.i4 30";
            s[6] = "sub";
            s[7] = "ldc.i4 20";
            s[8] = "div";
            s[9] = "ldc.i4 5";
            s[10] = "mul";
            s[11] = "ldc.i4 25";
            s[12] = "rem";
            s[13] = "}";
            
            // on verifi que les méthodes on bien était ajouter a la library

            p.LoadCode(s);
            p.compile();
            Assert.That(p.ErrorMessages.Count, Is.EqualTo(0));

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
