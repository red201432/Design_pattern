using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public  class Builder1:abstractBuilder
    {
       private Builder builder = new Builder();
       public override void BuilderPartA()
       {
           builder.Add("部件A");
       }
       public override void BuilderPartB()
       {
           builder.Add("部件B");
       }
       public override Builder getBuilder()
       {
           return builder;
       }

    }
}
