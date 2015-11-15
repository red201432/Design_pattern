using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using StrategyCore;

namespace StrategyTest
{
    [TestFixture]
    class StrategyTests
    {
        double money;
        double result;
        [SetUp]
        public void setValue()
        {
             money = 100;
             result = 100;
        }
        [Test]
        public void CashNormalTest() {
            CashContext cc = new CashContext(new CashNormal());
            Assert.AreEqual(result,cc.GetResult(money));
        }
        [Test]
        public void CashRebateTest() {
            CashContext cc = new CashContext(new CashRebate("0.8"));
            Assert.AreEqual(result * 0.8, cc.GetResult(money));     
        }

        [Test]
        public void CashReturnTest() {
            CashContext cc = new CashContext(new CashReturn("300","100"));
            Assert.AreEqual(200,cc.GetResult(300));
        }
    }
}
