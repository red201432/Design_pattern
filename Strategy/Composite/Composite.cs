using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 组合模式，将对象组合成树形的结构以表示“部分-整体”的层次关系。
    /// 组合模式使得用户对单个对象和组合对象的使用一致。
    /// 当发现需求中使体现部分与整体层次的结构时，
    /// 以及你希望用户可以忽略组合对象与单个对象的不同，
    /// 统一的使用组合结构中的所有对象时，就应该考虑使用组合模式。
    /// asp.net中的控件就是采用的组合模式
    /// </summary>
   public abstract class Composite
    {
        protected string name;
        public Composite(string name)
        {
            this.name = name;
        }

        public abstract void Add(Composite c);
        public abstract void Remove(Composite c);
        public abstract void Display(int depth);
    }
}
