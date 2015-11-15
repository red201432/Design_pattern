using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰模式
    /// 动态的给一个对象添加一些额外的功能，就增加的功能来说，装饰模式比生成子类更加灵活。
    /// </summary>
   public class Component
    {
        public Component() { }
        private String name;
        public Component(string name){
            this.name=name;
        }
        public virtual void show(){
            Console.WriteLine("装扮的{0}",name);
        }
    }
}
