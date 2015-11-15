using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 原型模式，用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
    /// 从一个对象创建另一个可定制的对象，而且不需要知道任何细节。
    /// 一般在初始化信息不发生改变的情况下，克隆是最好的方法，既隐藏了创建的细节，又对性能是大大的提高。
    /// </summary>
   public abstract class Prototype
    {
        private string id;
        public Prototype(string id) {
            this.id = id;
            }
        public string Id { get { return id; } }

        public abstract Prototype Clone();//在抽象内定义一个抽象的Clone方法
    }
}
