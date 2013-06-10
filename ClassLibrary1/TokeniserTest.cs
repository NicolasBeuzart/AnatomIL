using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AnatomIL.test
{
    [TestFixture]
    public class TokeniserTest
    {

        [Test]
        public void TokenTest()
        {
            string[] s = { "void main()", "{", "ldc.i4 12", "}" };
            Tokeniser t = new Tokeniser(s);
            string st;
            EnumManager e = new EnumManager();
            OpCodeRoot r;
            OpCodeRoot r2 = new LdcOpCodeRoot(e);

            Assert.That(t.MatchNextToken(), Is.True);
            Assert.That(t.IsType(out st), Is.True, "type not define");
            Assert.That(t.IsString(out st), Is.False);
            Assert.That(t.MatchSpace(), Is.True);
            Assert.That(t.IsString(out st), Is.True);
            Assert.That(t.MatchOpenPar(), Is.True);
            Assert.That(t.MatchDot(), Is.False);
            Assert.That(t.MatchClosePar(), Is.True);
            Assert.That(t.IsEnd, Is.True);
            Assert.That(t.MatchNextToken(), Is.True);
            Assert.That(t.MatchOpenBraket(), Is.True);
            Assert.That(t.IsEnd, Is.True);
            Assert.That(t.MatchNextToken(), Is.True);
            Assert.That(t.IsInstruction(out r), Is.True);
            Assert.That(r.Name, Is.EqualTo(r2.Name));
            Assert.That(t.IsOption(out st), Is.True);
            Assert.That(t.IsArgument(out st), Is.True);
            Assert.That(st, Is.EqualTo("12"));
            Assert.That(t.IsEnd, Is.True);
            Assert.That(t.MatchNextToken(), Is.True);
            Assert.That(t.MatchcloseBraket(), Is.True);


        }
    }
}
