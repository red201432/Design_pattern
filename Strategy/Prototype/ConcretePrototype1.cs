using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
   public  class ConcretePrototype1:Prototype
    {
        public ConcretePrototype1(string id) : base(id) { 
            
        }
        public override Prototype Clone()
        {
            try {
                return (Prototype)this.MemberwiseClone();//创建当前对象的浅表副本。方法是创建一个新的对象，然后将大概年前对象的非静态字段复制到新对象。如果只引用对象，则复制引用。
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
    }
}
