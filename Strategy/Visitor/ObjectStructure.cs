using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        public void Add(Person element)
        {
            elements.Add(element);
        }
        public void Remove(Person element)
        {
            elements.Remove(element);
        }
        public void Display(Action visitor)
        {
            foreach (Person p in elements)
            {
                p.Accept(visitor);
            }
        }
    }
}
