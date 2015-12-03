using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 迭代器模式
    /// 提供一个方法访问聚合对象中各个元素，而又不暴露改对象的内部表示。
    /// 当需要访问一个聚合对象，而不关心这些对象是什么的时候，就需要使用迭代器模式。或者需要对聚集有多种方式遍历。
    /// 为遍历不同的聚集结构提供一个如何开始、下一个、是否结束、当前哪一个等统一的接口。
    /// 
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();

    }
}
