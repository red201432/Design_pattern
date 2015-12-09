
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class ConcreteHandler1 : Handler {

    /**
     * 
     */
    public ConcreteHandler1() {
    }

    /**
     * @param request
     */
    public  override void HandlerRequest(int request) {
        // TODO implement here
        if (request >= 10 && request < 20)
        {
            Console.WriteLine("{0} ´¦ÀíÇëÇó {1}", this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandlerRequest(request);
        }
    }

}