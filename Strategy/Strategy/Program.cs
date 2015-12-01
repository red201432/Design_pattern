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
using AbstractFactory;
using System.Reflection;
using Facade;
using Builder;
using Observer;
using State;
using Memento;
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

            #region 抽象工厂方法
            User user = new User();

            IFactory factory = new SqlServerFactory();
            IUser iu = factory.CreateUser();
            //IUser riu = (IUser)Assembly.Load("AbstractFactory").CreateInstance("SqlserverUser");
            //反射  
            //Assembly.Load("程序集名称").CreateInstance("程序集名称.类名称");
            iu.Insert(user);
            iu.GetUser(1);
#endregion

            #region Facade 外观模式
            Fund jijin = new Fund();
            jijin.BuyFund();
            jijin.sellFund();
            #endregion

            #region 建造者模式
            Director director = new Director();
            abstractBuilder builder1 = new Builder1();
            abstractBuilder builder2 = new BuilderB();
            director.Construct(builder1);
            Builder.Builder b1 = builder1.getBuilder();
            b1.show();

            director.Construct(builder2);
            Builder.Builder b2 = builder2.getBuilder();
            b2.show();
            #endregion
            #region 观察者模式
            Observer.ConcreteSubject s = new Observer.ConcreteSubject();
            s.Attach(new Observer.ConcreteObserver(s, "x"));
            s.Attach(new Observer.ConcreteObserver(s, "y"));
            s.SubjectState = "ABC";
            s.Notify();
            ///下面是使用委托
            ///委托就是一种引用方法的类型。一旦为委托分配了方法，委托将于该方法具有完全相同的行为。
            ///委托方法的使用可以像其他的方法一样具有参数和返回值。委托可以看作是对函数的抽象，是函数的”类“，委托的实例将代表一个具体的函数
            ///一个委托可以搭载多个方法，所有方法被依次唤起，委托搭载的方法不需要属于同一个类，只需要具有相同的原型和形式，也就是拥有相同的参数列表和返回类型。
            ///在使用带参数的委托时，只需要在声明事件的地方将参数传递给事件。在绑定时将调用的方法绑定给事件。
            Bosscs boss = new Bosscs();
            StockObserver tongshi1 = new StockObserver("tongshi1",boss);
            NBAObserver tongshiNBA = new NBAObserver("tongshiNBA", boss);
            boss.Update += new EventHandler1(tongshi1.CloseStockMarket);
            boss.Update += new EventHandler1(tongshiNBA.CloseStockMarket);
            boss.update2 += new EventHandler2(tongshiNBA.print);
            boss.SubjectState = " I am back ";
            boss.Notify();            
            #endregion


            #region 状态模式
            Context c = new Context(new CreateStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
           
            #endregion

            #region 备忘录模式
            Originator o = new Originator();
            o.State = "On";
            o.Show();
            Caretaker care = new Caretaker();
            care.Memento = o.CreateMemento();
            o.State = "Off";
            o.Show();

            o.SetMemento(care.Memento);
            o.Show();
            #endregion

            Console.Read();
        }
    }
}
