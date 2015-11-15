using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SimpleFactory;

namespace SimpleFactoryTest
{
    [TestFixture]
    class AddOperationTest
    {
        [Test]
        public void Testadd()
        {        
            Opration add=OperationFactory.createOperation("+");
            add.NumberA = 33;
            add.NumberB = 23;
            double result=add.GetResult();
            Assert.AreEqual(56, result);
        }
        [Test]
        public void TestSub()
        {
            Opration sub = OperationFactory.createOperation("-");
            sub.NumberA = 33;
            sub.NumberB = 23;
            double result = sub.GetResult();
            Assert.AreEqual(10, result);
        }
        [Test]
        public void TestMul()
        {
            Opration add = OperationFactory.createOperation("*");
            add.NumberA = 33;
            add.NumberB = 23;
            double result = add.GetResult();
            double mul = add.NumberB * add.NumberA;
            Assert.AreEqual(mul, result);
        }
        [Test]
        public void TestDiv()
        {
            Opration add = OperationFactory.createOperation("/");
            add.NumberA = 33;
            add.NumberB = 23;
            double result = add.GetResult();
            double mul = add.NumberA / add.NumberB;
            Assert.AreEqual(mul, result);
        }

    }
}
