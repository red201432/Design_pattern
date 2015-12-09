using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 职责链模式使多个对象都有机会处理请求，从而避免请求的发送者和接受者之间的耦合关系。将这些对象连成一条链，并沿着
    /// 这个链传递该请求，知道有一个对象处理它为止。
    /// 当用户提交一个请求时，请求是沿链传递直至有一个对象来处理它。
    /// 这就使得接受者和发送者都没有对方的明确信息，且链中的对象自己也不知道链的结构。
    /// 结果是职责链可以简化对象的相互链接，只需保存一个指向其后继者的引用，而不需要保持它所有的候选接受者的引用。
    /// 可以随时增加或修改处理一个请求的结构。增强了给对象指派职责的灵活性。
    /// 
    /// 需要注意如下：
    /// 一个请求极有可能到了链的末尾都得不到处理，或者因为没有正确配置而得不到处理。需要事先考虑全面。
    /// 
    /// </summary>
    public class Class1
    {

    }
}
