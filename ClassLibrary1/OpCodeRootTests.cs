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
            FunctionTokeniser tok = new FunctionTokeniser(code);

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
        public void TestForOpCodeRoot()
        {
            AddOpCodeRoot add = new AddOpCodeRoot();
            OpCodeRootResult result;
            string[] code = {"", "."};
            List<string> options = new List<string>();
            List<string> args = new List<string>();
            FunctionTokeniser t = new FunctionTokeniser(code);

            t.MatchNextToken();
            result = add.Parse(t);
            Assert.That(result.IsSuccess, Is.True);

            t.MatchNextToken();
            result = add.Parse(t);
            Assert.That(result.IsSuccess, Is.False);
        }

    }
}
