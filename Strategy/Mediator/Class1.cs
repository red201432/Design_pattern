﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// 尽管将一个系统分割成许多对象通常可以增加其可复用性，但是对象间相互连接的激增又会降低其可复用性。
    /// 大量的连接使得一个对象不可能在没有其他对象的支持下工作，系统表现为一个不可分割的整体。所以对系统进行比较大的
    /// 修改就比较困难了。
    /// 
    /// 中介者模式，用一个中介对象来封装一系列的对象交互。中介者使对象不需要显示的相互引用，从而使其耦合松散，而且可以独立的改变它们之间的交互。
    /// 中介者模式很容易在系统中被滥用，当系统中出现多对多交互复杂对象群时，要反思系统设计是否合理。
    /// 把对象如何协作进行了抽象，将中介作为一个独立的概念将其封装在一个对象内，这样关注的对象就从对象本身的行为转移到对象间的交互上面。
    /// 中介者模式一般应用于一组对象以定义良好但是复杂的方式进行通信的场合，以及想定制一个分布在多个类中的行为，而不想生成太多子类的场合。
    /// </summary>
    public class Class1
    {
    }
}