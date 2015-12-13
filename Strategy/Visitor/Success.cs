using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Success:Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine(concreteElementA.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个伟大的女人。");
            //throw new NotImplementedException();
        }
        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine(concreteElementB.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个不成功的男人。");
            //throw new NotImplementedException();
        }
    }

    public class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine(concreteElementA.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个伟大的女人。");
            //throw new NotImplementedException();
        }
        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine(concreteElementB.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个不成功的男人。");
            //throw new NotImplementedException();
        }
    }
    public class Amativeness:Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine(concreteElementA.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个伟大的女人。");
            //throw new NotImplementedException();
        }
        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine(concreteElementB.GetType().Name + " " + this.GetType().Name + "时，背后多半有一个不成功的男人。");
            //throw new NotImplementedException();
        }
    }
}
