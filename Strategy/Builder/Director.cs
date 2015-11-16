using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指挥者类，
    /// </summary>
    public class Director
    {
        public void Construct(abstractBuilder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }
}
