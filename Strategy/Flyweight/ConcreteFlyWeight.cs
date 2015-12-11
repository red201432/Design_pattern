
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Flyweight
{
    /**
     * 
     */
    public class ConcreteFlyWeight : Flyweight
    {

        /**
         * 
         */
        public ConcreteFlyWeight()
        {
        }

        /**
         * @param extrinsic
         */
        public override void Operation(int extrinsic)
        {
            // TODO implement here
            Console.WriteLine("¾‗Ìו FlyWeight" + extrinsic);
        }

    }
}