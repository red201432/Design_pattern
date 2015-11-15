using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
   public  class TestPaperB:TestPaper
    {
       public override string Answer1()
       {
           return "a";
           //throw new NotImplementedException();
       }
       public override string Answer2()
       {
           return "b";
           //throw new NotImplementedException();
       }
    }
}
