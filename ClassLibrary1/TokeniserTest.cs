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
            Tokeniser t = new Tokeniser("void main()\n{\nldc.i4 12\nldc.i4 12\nadd\n}");

            Assert.That(t.MatchNextToken(), Is.True);
            Assert.That(t.Prototype,  Is.EquivalentTo("void main()"));
            Assert.That(t.CurentToken, Is.EquivalentTo("\nldc.i4 12\nldc.i4 12\nadd\n"));


            Assert.That(t.MatchNextToken(), Is.False);

        }
    }
}
