using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AnatomIL.test
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void FirstStackCreated()
        {
            Stack s = new Stack();

            Assert.That(s.Count == 0, "The stack is not empty : bad initialisation");

            StackItem si = new StackItem(typeof(Int32), 22);


           s.Push(si.Type, si.Value);

           StackItem si2 = new StackItem(typeof(Int32), 54);

            si2 = s.FirstElement();

            Assert.That(s.Count != 0, "The stack is empty but si has been push on");

            Assert.That(si2.Type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type");

            Assert.That(si2.Value, Is.EqualTo(22), "Bad initialisation of the value");
        }

        [Test]
        public void PushAndPopItems()
        {
            Stack s = new Stack();

            StackItem si = new StackItem(typeof(Int32), 22);
            StackItem si2 = new StackItem(typeof(String), "vrezvr");


            s.Push(si.Type, si.Value);
            s.Push(si2.Type, si2.Value);

            Assert.That(s.Count == 2, "2 item has been push in stack but there is actually {0} item in stack",s.Count);

            StackItem sip = s.Pop();

            Assert.That(sip.Type, Is.EqualTo(typeof(string)), "Bad initialisation of the type or Pop method");

            Assert.That(sip.Value, Is.EqualTo("vrezvr"), "Bad initialisation of the value or Pop method");

            Assert.That(s.Count == 1, "2 item has been push in stack and one has been pop but there is actually {0} item in stack", s.Count);

            sip = s.FirstElement();

            Assert.That(sip.Type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type or CurrentStack method");

            Assert.That(sip.Value, Is.EqualTo(22), "Bad initialisation of the value or CurrentStack method");

            sip = s.Pop();

            Assert.That(s.Count == 0, "The stack has to be empty but there is still {0} items in", s.Count);
        }

    }
}
