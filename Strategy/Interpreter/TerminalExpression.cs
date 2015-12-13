using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
     public class TerminalExpression:AbstractExpression
    {
         public override void Interpreter(Context context)
         {
             Console.WriteLine("终端解释器");
             //throw new NotImplementedException();
         }
    }
}
