using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
     public class DivOperation:Opration
    {
         public override double GetResult()
         {
             double result = 0;
             if (NumberB == 0)
                 throw new Exception("除数不能为 0 ！！！");
             result = NumberA / NumberB;
             return result;
         }
    }
}
