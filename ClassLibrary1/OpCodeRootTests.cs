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

            List<string> options = new List<string>();
            List<string> args = new List<string>();

            args.Add("label");

            OpCodeRootResult r = t.Parse(options, args);
            Assert.That(r.IsSuccess, Is.True);

            options.Add("un");

            r = t.Parse(options, args);
            Assert.That(r.IsSuccess, Is.True);

            options.Add("");
            r = t.Parse(options, args);
            Assert.That(r.IsSuccess, Is.False);

            options.Clear();
            options.Add("");
            r = t.Parse(options, args);
            Assert.That(r.IsSuccess, Is.False);
        }


        [Test]
        public void TestForOpCodeRoot()
        {
            AddOpCodeRoot add = new AddOpCodeRoot();
            OpCodeRootResult result;
            List<string> options = new List<string>();
            List<string> args = new List<string>();

            result = add.Parse(options, args);
            Assert.That(result.IsSuccess, Is.True);

            options.Add("");
            result = add.Parse(options, args);
            Assert.That(result.IsSuccess, Is.False);
        }

    }
}
