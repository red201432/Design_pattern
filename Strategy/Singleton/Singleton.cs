using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单例模式：保证一个类只有一个实例，并提供一个访问它的全局访问点。
    /// 通常我们可以让一个全局变量使得一个对象被访问，但它不能防止你实例化多个对象。一个最好的办法就是，让类自身负责保存它的唯一实例。这个类可以保证没有其他的实例被创建，并且它可以提供一个访问该实例的方法。
    /// 可以严格的控制客户怎样访问它以及何时访问它。
    /// 在多线程时需要对进程加锁来进行处理，Lock是确保当一个线程位于代码的临界区时，另一个线程不会进入临界区。
    /// 当其他的进程试图进入锁定的代码，会一直等待，知道该对象释放。
    /// 此时可以采取双向锁定的方法，提高效率，避免每次加锁。
    /// 
    /// </summary>
    public class Singleton
    {
        //private static readonly Singleton instance = new Singleton();//readonly意味着只能在静态初始化期间或在类构造函数中分配变量。这样的静态初始化方式是在自己被加载时就将自己实例化，称为饿汉式单例类。
        private static Singleton instance;//在第一次被引用时，才会将自己实例化，懒汉式单例类。
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
}
