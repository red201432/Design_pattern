
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Flyweight { 
/**
 * 
 */
    public class UnsharedConcreteFlyWeight : Flyweight
    {

        /**
         * 
         */
        public UnsharedConcreteFlyWeight()
        {
        }

        /**
         * @param extrinsic
         */
        public override void Operation(int extrinsic)
        {
            // TODO implement here
            Console.WriteLine("������ľ��� FlyWeight" + extrinsic);
        }

    }
}