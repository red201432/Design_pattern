using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// 状态模式，当一个对象的状态改变时允许改变其行为，这个对象看起来像是改变了其类。
    /// 主要解决当控制一个对象状态转换的条件表达过于复杂时的情况。把状态的判断逻辑转移
    /// 到表示不同状态的一系列类中，可以把复杂的逻辑简化。
    /// 如果状态的转换很简单，就没必要使用这个模式了。
    /// </summary>
   public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
