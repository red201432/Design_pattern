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
    /// 
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
