
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class ConcreteHandler2 : Handler {

    /**
     * 
     */
    public ConcreteHandler2() {
    }



    /**
     * @param request
     */
    public override void HandlerRequest(int request) {
        // TODO implement here
        if (request >= 0 && request < 10)
        {
            Console.WriteLine("{0} ´¦ÀíÇëÇó {1}", this.GetType().Name, request);
        }
        else if(successor!=null)
        {
            successor.HandlerRequest(request);
        }
    }

}