using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    /// <summary>
    ///声明一个抽象的解释操作，这个接口为抽象语法树中所有的节点所共享。
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpreter(Context context);
    }
}
