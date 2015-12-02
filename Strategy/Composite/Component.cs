using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Component:Composite
    {
        private List<Composite> children = new List<Composite>();
        public Component(string name) : base(name) { }
        public override void Add(Composite c)
        {
            children.Add(c);
        }
        public override void Remove(Composite c)
        {
            children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (Composite composite in children)
            {
                composite.Display(depth + 2);
            }
        }
    }
}
