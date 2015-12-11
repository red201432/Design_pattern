
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
namespace Flyweight { 
/**
 * 
 */
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        /**
         * 
         */
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyWeight());
            flyweights.Add("Y", new ConcreteFlyWeight());
            flyweights.Add("Z", new UnsharedConcreteFlyWeight());
        }


        /**
         * @param key 
         * @return
         */
        public Flyweight GetFlyweight(string key)
        {
            // TODO implement here
            return ((Flyweight)flyweights[key]);
        }
    }
}