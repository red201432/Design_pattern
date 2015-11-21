using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。
    /// 这个主题的状态发生变化时，会通知所有的观察者对象，使它们能够自己更新自己。
    /// </summary>
   public abstract class Subject
    {
       private IList<Observer> observers = new List<Observer>();
       
       //增加观察者
       public void Attach(Observer observer)
       {
           observers.Add(observer);
       }
       //移除观察者
       public void Detach(Observer observer)
       {
           observers.Remove(observer);
       }

       public void Notify()
       {
           foreach (Observer o in observers)
           {
               o.Update();
           }
       }
    }
}
