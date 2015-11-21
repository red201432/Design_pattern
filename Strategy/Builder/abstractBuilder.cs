using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 抽象的建造类
    /// </summary>
    public abstract class abstractBuilder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Builder getBuilder();
    }
}
