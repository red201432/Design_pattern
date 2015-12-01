using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// 备忘录模式
    /// 在不破坏封装性的前提下，捕获一个对象的内部状态
    /// 并在该对象之外保存这个状态。这样以后就可将该对象恢复
    /// 到原先保存的状态。
    /// </summary>
    public class Memento
    {
        //备忘录负责保存Originator对象的内部状态，并可防止Originator以外的其他对象访问备忘录Memento。
        //备忘录又两个接口，Caretaker只能看到备忘录的窄接口，它只能将备忘录传递给其他对象。
        //Originator能够看到一个宽接口，允许它返回到先前状态所需的全部数据。
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }

        public string State
        {
            get { return state; }
        }
    }
}
