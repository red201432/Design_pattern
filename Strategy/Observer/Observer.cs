using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 将一个系统分割为一些列相互协作的类有一个很不好的副作用，那就是需要维护相关对象间的一致性。
    /// 我们不希望为了维持一致性而使各类紧密耦合，这样会给维护、扩展和重用都带来不便。
    /// 当一个对象的改变需要改变其他对象的时候，需要使用观察者模式。观察者模式做的工作就是接触耦合。
    /// 让耦合的双方都依赖于抽象，而不是依赖于具体。从而使各自的变化都不会影响另一边的变化。
    /// 
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}
