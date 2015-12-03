using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConCreteIterator:Iterator
    {
        private ConCreteAggregate aggregate;
        private int current = 0;

        public ConCreteIterator(ConCreteAggregate aggre)
        {
            this.aggregate = aggre;
        }
        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if(current<aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
