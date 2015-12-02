using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf:Composite
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Composite c)
        {
            Console.WriteLine("Can not add to a leaf");
        }
        public override void Remove(Composite c)
        {
            Console.WriteLine("Can not remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
