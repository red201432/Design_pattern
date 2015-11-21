using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象工厂模式，提供一个创建一系列相关，或者相互依赖的对象的接口，而无需指定它们的具体类。
    /// 让具体的创建实例的过程与客户端分离，客户端通过抽象的接口来操作实例。
    /// 
    /// </summary>
    public interface IFactory
    {
        IUser CreateUser();
    }
}
