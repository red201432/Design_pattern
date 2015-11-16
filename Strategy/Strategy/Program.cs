using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyCore;
using Decorator;
using Proxy;
using Prototype;
using TemplateMethod;
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 工厂方法
            double total = 0.0d;
            CashContext cc = new CashContext(new CashNormal());
            total = cc.GetResult(100.04);
            cc = new CashContext(new CashRebate("0.8"));
            total = cc.GetResult(100.04);
            Console.WriteLine(total);
            #endregion

            #region 装饰器方法
            Component person = new Component("xiaocai");

            Tshirt tshirt = new Tshirt();
            BigTrouser bt = new BigTrouser();

            bt.Decorator(person);
            tshirt.Decorator(bt);
            tshirt.show();

            Console.WriteLine("*****************************");
            #endregion

            #region 代理方法
            SchoolGirl sg = new SchoolGirl();
            sg.Name = "李娇骄";
            Proxy.Proxy daili = new Proxy.Proxy(sg);
            daili.GiveDolls();
            daili.GiveFlowers();
            #endregion

            #region 原型模式
            ConcretePrototype1 p1 = new ConcretePrototype1("123");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned :"+c1.Id);

            Resume a = new Resume("Andy");
            a.setInfo("Man", "24");
            a.setWorkExperience("1998-2005","IBM ");
            Resume b = (Resume)a.Clone();
            b.setWorkExperience("2002-2005", "Dell");
            a.display();
            b.display();
            #endregion

            #region 模板模式
            Console.WriteLine("Student A testPaper:");
            TestPaperA testA = new TestPaperA();
            testA.Test1();
            testA.Test2();
            Console.WriteLine("Student B testPaper:");
            TestPaperB testB = new TestPaperB();
            testB.Test1();
            testB.Test2();
            #endregion
        }
    }
}
