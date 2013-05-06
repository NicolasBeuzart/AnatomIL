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

            StackItemValue si = new StackItemValue(typeof(Int32), 22);


           s.Push(si.Type, si.Value);

           StackItemValue si2;

           if (s.FirstElement(out si2))
           {

               Assert.That(s.Count != 0, "The stack is empty but si has been push on");

               Assert.That(si2.Type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type");

               Assert.That(si2.Value, Is.EqualTo(22), "Bad initialisation of the value");
           }
        }

        [Test]
        public void PushAndPopItems()
        {
            Stack s = new Stack();

            StackItemValue si = new StackItemValue(typeof(Int32), 22);
            StackItemValue si2 = new StackItemValue(typeof(String), "vrezvr");


            s.Push(si.Type, si.Value);
            s.Push(si2.Type, si2.Value);

            Assert.That(s.Count == 2, "2 item has been push in stack but there is actually {0} item in stack",s.Count);

            StackItemValue sip;

            if (s.Pop(out sip))
            {
                Assert.That(sip.Type, Is.EqualTo(typeof(string)), "Bad initialisation of the type or Pop method");

                Assert.That(sip.Value, Is.EqualTo("vrezvr"), "Bad initialisation of the value or Pop method");

                Assert.That(s.Count == 1, "2 item has been push in stack and one has been pop but there is actually {0} item in stack", s.Count);
            }

            if (s.FirstElement(out sip))
            {
                Assert.That(sip.Type, Is.EqualTo(typeof(Int32)), "Bad initialisation of the type or CurrentStack method");

                Assert.That(sip.Value, Is.EqualTo(22), "Bad initialisation of the value or CurrentStack method");
            }

            if (s.Pop(out sip))
            {
                Assert.That(s.Count == 0, "The stack has to be empty but there is still {0} items in", s.Count);
            }
        }

    }
}
