using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 命令模式，将一个请求封装为一个对象，从而使你可以用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销操作。
    /// 优点：
    /// 能够比较容易的设计一个命令队列
    /// 在需要的情况下较容易的将命令记入日志
    /// 允许接收请求的一方是否要否决请求
    /// 容易的允许对请求的撤销和修改
    /// 对新加入的类不影响其他的类，因此易于增加新的命令类
    /// 
    /// 命令模式把请求一个操作的对象与知道怎么执行一个操作的对象分开。
    /// </summary>
    public class Class1
    {
    }
}
