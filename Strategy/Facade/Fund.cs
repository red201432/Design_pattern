using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 外观模式，为子系统的一组接口提供一个统一的界面，此模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
    /// 何时使用外观模式:
    /// 在设计初期，应该有意识将不同的层分离，层与层之间建立外观Facade
    /// 在开发阶段，子系统往往因为不断的重构演化而变得越来越复杂，增加外观Facade可以提供一个统一的接口，减少它们之间的依赖。
    /// 在维护一个大型系统时，可能这个系统已经非常难以维护和扩展了，这时可以为新系统开发一个外观Facade，来提供设计粗糙或高度复杂的遗留代码的比较清晰的简单接口，让新系统与Facade对象交互，Facade与遗留代码交互所有复杂的工作。
    /// 
    /// </summary>
    public class Fund
    {
        Stock1 gu1;
        Stock2 gu2;
        Stock3 gu3;
        NationlDebt1 nd1;
        Realty1 rt1;
        public Fund()
        {
            gu1 = new Stock1();
            gu2 = new Stock2();
            gu3 = new Stock3();
            nd1 = new NationlDebt1();
            rt1 = new Realty1();
        }
        public void BuyFund() {
            gu1.Buy();
            gu2.Buy();
            gu3.Buy();
            nd1.Buy();
            rt1.Buy();
        }

        public void sellFund()
        {
            gu1.sell();
            gu2.sell();
            gu3.sell();
            nd1.sell();
            rt1.sell();
                    }
    }
}
