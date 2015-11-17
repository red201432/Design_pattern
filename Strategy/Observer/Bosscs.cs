using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public delegate void EventHandler1();
    public delegate string EventHandler2(string s);
   public class Bosscs:ISubject
    {
       
       public event EventHandler1 Update;
       public event EventHandler2 update2;
       private string action;
       public void Notify()
       {
           Update();
           Console.WriteLine(update2(action+"123"));
       }
       public string SubjectState { get { return action; } set { action = value; } }
    }
}
