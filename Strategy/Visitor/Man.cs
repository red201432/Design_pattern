using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Man:Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
            //throw new NotImplementedException();
        }
    }
}
