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
    /// 这样带来的好处是将要保存的细节都封装在了Memento类中，当更改保存的细节时也不用修改客户端。
    /// 备忘录模式适用于功能比较复杂的，但需要维护或者记录属性历史的类，或者需要保存的属性只是众多属性中的一小部分。
    /// 如果在某个系统中，使用命令模式时，需要实现命令的撤销功能，那么命令模式可以使用备忘录模式来存储可撤销操作的状态。
    /// 当角色的状态改变时，有可能这个状态无效，这时候就可以使用暂时保存起来的备忘录将状态复原。
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
