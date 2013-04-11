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

            StackItem si = new StackItem();

            si.value = 22;
            si.type = typeof(Int32);

            s.Push(si);

            StackItem si2 = new StackItem();

            si2 = s.CurrentStack();

            Assert.That(s.Count != 0, "The stack is empty but si has been push on");

            Assert.That(si2.type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type");

            Assert.That(si2.value, Is.EqualTo(22), "Bad initialisation of the value");
        }

        [Test]
        public void PushAndPopItems()
        {
            Stack s = new Stack();

            StackItem si = new StackItem();
            StackItem si2 = new StackItem();
            StackItem sip = new StackItem();

            si.value = 22;
            si.type = typeof(Int32);

            si2.value = "vrezvr";
            si2.type = typeof(String);

            s.Push(si);
            s.Push(si2);

            Assert.That(s.Count == 2, "2 item has been push in stack but there is actually {0} item in stack",s.Count);

            sip = s.Pop();

            Assert.That(sip.type, Is.EqualTo(typeof(string)), "Bad initialisation of the type or Pop method");

            Assert.That(sip.value, Is.EqualTo("vrezvr"), "Bad initialisation of the value or Pop method");

            Assert.That(s.Count == 1, "2 item has been push in stack and one has been pop but there is actually {0} item in stack", s.Count);

            sip = s.CurrentStack();

            Assert.That(sip.type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type or CurrentStack method");

            Assert.That(sip.value, Is.EqualTo(22), "Bad initialisation of the value or CurrentStack method");

            sip = s.Pop();

            Assert.That(s.Count == 0, "The stack has to be empty but there is still {0} items in", s.Count);
        }

    }
}
