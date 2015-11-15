using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq.Properties;
using Moq;
using Decorator;
namespace StrategyTest
{
    [TestFixture]
   public class DecoratorTest
    {
        static Component component = new Component("xiaohua");
      
       [Test]
        public void TshirtTest()
        {
            Tshirt tshirt = new Tshirt();
            tshirt.Decorator(component);
        }
    }
}
