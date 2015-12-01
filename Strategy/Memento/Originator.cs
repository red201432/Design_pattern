using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// 发起人，负责创建一个备忘录Memento，用以记录当前时刻它的内部状态，并可使备忘录恢复内部状态。
    /// Originator可根据需要决定Memento存储Originator的哪些状态。
    /// 
    /// </summary>
   public class Originator
    {
       private string state;
       public string State { get { return state; } set { state = value; } }

       public Memento CreateMemento()
       {
           return (new Memento(state));
       }
       public void SetMemento(Memento memento)
       {
           state = memento.State;
       }
       public void Show()
       {
           Console.WriteLine("State is "+state);
       }
    }
}
