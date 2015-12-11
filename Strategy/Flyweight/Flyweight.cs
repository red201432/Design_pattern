
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Flyweight
{
  /// <summary>
  /// 享元对象内部并且不会随环境改变而改变的共享部分，称为享元对象的内部状态。
  /// 享元模式可以避免大量的非常相似类的开销。在程序设计中，有时需要生成大量细粒度的类实例来表示数据。
  /// 如果发现这些实例除了几个参数外基本上都是相同的，有时就能接受大幅度的减少需要实例化类的数量。
  /// 如果能把那些参数移到类实例的外面，在方法调用时将它们传递进来，就可以通过享元减少单个实例的数量。
  /// 
  /// 如果一个应用程序使用了大量的对象，而大量的对象造成了很大的存储开销时就应该考虑使用。
  /// 还有就是对象的大多数状态都是外部状态，如果删除外部状态，那么可以用较少的共享对象来取代很多的对象。
  /// 使用享元模式，有了共享对象，实例总数就会大大降低。
  /// 是一种相对底层的设计模式，比如 .NET中的字符串 string
  /// </summary>
    public abstract class Flyweight
    {

        /**
         * 
         */
        public Flyweight()
        {
        }


        /**
         * @param extrinsic
         */
        public abstract void Operation(int extrinsic);

    }
}