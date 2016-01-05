using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
<<<<<<< HEAD
    public  abstract  class AbstractExpression
    {
       public abstract void Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }

    }

    public class NormalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }

    }

=======
    /// <summary>
    ///声明一个抽象的解释操作，这个接口为抽象语法树中所有的节点所共享。
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpreter(Context context);
    }
>>>>>>> 77e342ef6e96917a8dc01e72e41626dcffd4ba13
}
