using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 当创建复杂对象时，创建对象的算法应该独立于该对象的组成部分以及它们的装配方式时适用的模式。
    /// 将一个复杂对象的创建和表示分离，使得同样的创建过程可以创建不同的表示。
    /// 只需要指定需要建造的类型，具体建造的细节和过程就不知道了
    /// 
    /// </summary>
    public class Builder
    {
        IList<String> parts=new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void show()
        {
            Console.WriteLine(" 产品创建：");
            foreach (string s in parts)
            {
                Console.WriteLine(s);
            }
        }
    }
}
