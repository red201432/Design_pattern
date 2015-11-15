using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 具体的装饰类
    /// </summary>
  public  class BigTrouser:Finery
    {
        public override void show()
        {
            Console.WriteLine("BigTrouser");
            base.show();
        }
    }
}
