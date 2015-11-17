using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 具体的被观察者
    /// </summary>
   public class ConcreteSubject :Subject
    {
       private string subjectState;
       public string SubjectState { get; set; }

    }
}
