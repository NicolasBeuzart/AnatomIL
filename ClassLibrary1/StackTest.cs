//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;

//namespace AnatomIL.test
//{
//    [TestFixture]
//    public class StackTest
//    {
//        [Test]
//        public void FirstStackCreated()
//        {
//             Stack s = new Stack();

//             Assert.That(s.IsEmpty, Is.Not.False, "The stack is not empty : bad initialisation");

//             s.Push(22);

//             Assert.That(s.IsEmpty, Is.False, "The stack is empty but 22 has been push on");
//        }

//        [Test]
//        public void PushAndPopElements()
//        {
//            Stack s = new Stack();
//            object o = null;

//            s.Push(22);

//            s.Push("gzg");

//            o = s.Pop();

//            Assert.That(o.Equals("gzg"), "The string \"gzg\" hasn't been pop of the stack");

//            o = s.Pop();

//            Assert.That(o.Equals(22), "The number 22 hasn't been pop of the stack");

//            Assert.That(s.IsEmpty, Is.Not.Null, "The stack is not empty but should be");
//        }

//        [Test]
//        public void NumberOfElementsInStack()
//        {
//            Stack s = new Stack();
//            object o = null;

//            s.Push(22);
//            s.Push(34);
//            s.Push(57);
//            s.Push("tttt");

//            Assert.That(s.Count, Is.EqualTo(4), "4 item has been push in stack but there is actually {0}",s.Count);

//            o = s.Pop();

//            Assert.That(o.Equals("tttt"), "The string \"tttt\" hasn't been pop of the stack");

//            Assert.That(s.Count, Is.EqualTo(3), "4 item has been push in stack and one has been pop but there is actually {0} items in stack", s.Count);
//        }

//    }
//}
