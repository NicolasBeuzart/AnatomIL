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
            BgeOpCodeRoot t = new BgeOpCodeRoot();

            //OpCodeRootResult r = t.Parse("bge.un label");
            //Assert.That(r.IsSuccess, Is.True);

            //r = t.Parse("bge label");
            //Assert.That(r.IsSuccess, Is.True);

            //r = t.Parse("bge.un. label");
            //Assert.That(r.IsSuccess, Is.False);

            //r = t.Parse("bge. label");
            //Assert.That(r.IsSuccess, Is.False);
        }
    }
}
