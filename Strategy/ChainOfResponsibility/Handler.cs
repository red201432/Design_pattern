
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public abstract class Handler {

    /**
     * 
     */
    public Handler() {
    }

    /**
     * 
     */
    protected Handler successor;



    /**
     * @param successor
     */
    public void SetSuccessor(Handler successor) {
        // TODO implement here
        this.successor=successor;
    }

    /**
     * @param request
     */
    public abstract void HandlerRequest(int request);

}