using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AnatomIL.test
{

    [TestFixture]
    public class OpCodeRootTests
    {
        [Test]
        public void bgeOpCodeRootTest()
        {
            BgeOpCodeRoot Op = new BgeOpCodeRoot();
            string[] code = { " label", ".un label", ".un. label", ". label" };
            Tokeniser tok = new Tokeniser(code);

            tok.MatchNextToken();
            OpCodeRootResult r = Op.Parse(tok);
            Assert.That(r.IsSuccess, Is.True);

            tok.MatchNextToken();
            r = Op.Parse(tok);
            Assert.That(r.IsSuccess, Is.True);

            tok.MatchNextToken();
            r = Op.Parse(tok);
            Assert.That(r.IsSuccess, Is.False);

            tok.MatchNextToken();
            r = Op.Parse(tok);
            Assert.That(r.IsSuccess, Is.False);
        }


        [Test]
        public void AddOpCodeRootTest()
        {
            AddOpCodeRoot add = new AddOpCodeRoot();
            OpCodeRootResult result;
            string[] code = {"", "."};
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = add.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = add.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void SubOpCodeRootTest()
        {
            SubOpCodeRoot sub = new SubOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "", "." };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = sub.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = sub.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void MulOpCodeRootTest()
        {
            MulOpCodeRoot mul = new MulOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "", ".", " 12" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = mul.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = mul.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = mul.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void DivOpCodeRootTest()
        {
            DivOpCodeRoot div = new DivOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "", ".", " 12" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = div.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = div.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = div.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void RemOpCodeRootTest()
        {
            RemOpCodeRoot rem = new RemOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "", ".", " 12" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = rem.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = rem.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = rem.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void LdcOpCodeRootTest()
        {
            EnumManager e = new EnumManager();
            LdcOpCodeRoot ldc = new LdcOpCodeRoot(e);
            OpCodeRootResult result;
            string[] code = { ".i4 12", ".i4", " 12", "", ".i2 12", ".i2 4564646456" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t._code[2] = " 12";
            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = ldc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void LabelOpCodeRootTest()
        {
            LabelOpCodeRoot label = new LabelOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "zaza", " zaza", ".12", "", "toto", "zaza:" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);
            t._code[1] = " zaza";

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = label.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void LocalsOpCodeRootTest()
        {
            LocalsInitOpCodeRoot locals = new LocalsInitOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "(int32, int16, int64)", "(int32, int16, int64", "int32, int64)", "", "(int16 L0)", "(int16 L0, caca)" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = locals.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void DupOpCodeRootTest()
        {
            DupOpCodeRoot dup = new DupOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "", ".un", " toto" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);
            t._code[2] = " toto";
            t.MatchNextToken();
            result = dup.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = dup.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = dup.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

        }

        [Test]
        public void StlocOpCodeRootTest()
        {
            stlocOpCodeRoot stloc = new stlocOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { " 1", ".1", " az", "" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = stloc.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = stloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = stloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = stloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

        }


        [Test]
        public void LdlocOpCodeRootTest()
        {
            ldlocOpCodeRoot ldloc = new ldlocOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { " 1", ".1", " az", "" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = ldloc.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = ldloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = ldloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = ldloc.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

        }


        [Test]
        public void prototypeOpCodeRootTest()
        {
            PrototypeOpCodeRoot prototype = new PrototypeOpCodeRoot();
            OpCodeRootResult result;
            string[] code = { "void main()", "int32 tutu(int32, int16)", "main()", "pouet pouet()" };
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            Tokeniser t = new Tokeniser(code);

            t.MatchNextToken();
            result = prototype.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = prototype.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = prototype.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

            t.MatchNextToken();
            result = prototype.Parse(t);
            Assert.That(result.IsSuccess, Is.False);

        }
    }
}
