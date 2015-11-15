using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //装饰类 对 component进行装饰
   public class Finery : Component {
        protected Component component;
        public void Decorator(Component component) {
            this.component = component;
        }
        public override void show(){
            if (component != null)
                component.show();
        }
    }
}
