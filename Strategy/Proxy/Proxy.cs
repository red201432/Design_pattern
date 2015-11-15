using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 代理模式是为其他对象提供一种代理以控制这个对象的访问。
    /// 代理类和被代理类 实现同样的方法，通过代理类隐藏了被代理类，但是方法的名称一样，使用起来感觉不到被代理类的存在
    /// 1 远程代理 ，为同一对象在不同的地址空间提供局部的代表。隐藏一个对象存在于不同地址空间的事实。
    /// 2 虚拟代理 ，根据需要创建开销很大的对象。通过它来存放实例化需要很长时间的真实对象。
    /// 3 安全代理， 用来控制对真实对象的访问权限。比如，用户登录 登录类作为代理，控制不同的访问调用
    /// 4 智能指引， 调用真实对象时，代理处理另一些事务。
    /// </summary>
   public  class Proxy:GiveGift
    {
       Persuit gg;
       public Proxy(SchoolGirl sg) {
           gg = new Persuit(sg);
       }
        public void GiveDolls()
        {
            gg.GiveDolls();
        }
        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
