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
using Memento.Game;
using Composite;
using Iterator;
using Singleton;
using Command;
using Mediator;
using Flyweight;
using Interpreter;
using Visitor;
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
            Decorator.Component person = new Decorator.Component("xiaocai");

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
            State.Context c = new State.Context(new CreateStateA());
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

            GameRole gameRole = new GameRole();
            gameRole.GetInitState();
            gameRole.StateDisplay();

            RoleStateManager stateManager = new RoleStateManager();
            stateManager.Memento = gameRole.SaveState();

            gameRole.Fight();
            gameRole.StateDisplay();

            gameRole.RecoveryState(stateManager.Memento);
            gameRole.StateDisplay();
            #endregion

            #region 组合模式
            Composite.Composite root = new Composite.Component("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite.Composite comp = new Composite.Component("comp X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);

            Composite.Composite comp2 = new Composite.Component("Comp X2");
            comp2.Add(new Leaf("Leaf X2A"));
            comp2.Add(new Leaf("Leaf X2B"));
            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));
            Leaf leaf = new Leaf("Leaf D");

            root.Add(leaf);
            root.Display(1);
            root.Remove(leaf);
            root.Display(1);
	        #endregion

            #region 迭代器模式
            ConCreteAggregate aggregate = new ConCreteAggregate();
            aggregate[0] = "大鸟";
            aggregate[1] = "小菜";
            aggregate[2]="行李";
            aggregate[3] = "老外";
            aggregate[4] = "小偷";
            Iterator.Iterator myIterator = new ConCreteIterator(aggregate);
            object item = myIterator.First();
            while (!myIterator.IsDone())
            {
                Console.WriteLine(myIterator.CurrentItem() + "请买车票");
                myIterator.Next();
            }
            #endregion

            #region 单例模式
             //所有类都有构造方法，不编码则默认生成空的构造方法，若有显示定义的构造方法，默认的构造方法就会失效。只要将构造方法改写为私有的，外部的程序就不能通过new 来初始化它。
            //通过一个共有的方法来返回类的实例。
            Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
            Singleton.Singleton s2 = Singleton.Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("两个对象是相同的实例。");
            }
            

            #endregion

            #region 命令模式
            Receiver r = new Receiver();
            Command.Command command = new Command.ConcreteCommand(r);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            #endregion

            #region 职责链模式
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.SetSuccessor(h2);
            int[] requests = { 2, 3, 4, 5, 6, 12, 34, 11, 15 };
            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }
            #endregion

            #region 中介者模式
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            colleague1.Send("吃饭了吗？");
            colleague2.Send("还没有呢");
            #endregion

            #region 享元模式
            int extri = 22;
            FlyweightFactory f = new FlyweightFactory();
            Flyweight.Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extri);

            Flyweight.Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extri);

            Flyweight.Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extri);

            #endregion

            #region 解释器模式
<<<<<<< HEAD
            Interpreter.Context context = new Interpreter.Context();
            IList<Interpreter.AbstractExpression> list = new List<Interpreter.AbstractExpression>();
            list.Add(new Interpreter.TerminalExpression());
            list.Add(new Interpreter.NormalExpression());
            foreach (Interpreter.AbstractExpression exp in list)
                exp.Interpret(context);
=======
            Interpreter.Context context1 = new Interpreter.Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            foreach (AbstractExpression exp in list)
            {
                exp.Interpreter(context1);
            }
            #endregion

            #region 访问者模式
            ObjectStructure os = new ObjectStructure();
            os.Add(new Man());
            os.Add(new Woman());
            Success v1 = new Success();
            os.Display(v1);
            Failing f1 = new Failing();
            os.Display(f1);

            Amativeness a1 = new Amativeness();
            os.Display(a1);
>>>>>>> 77e342ef6e96917a8dc01e72e41626dcffd4ba13
            #endregion
            Console.Read();

        }
    }
}
