
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Mediator { 
/**
 * 
 */
    public class ConcreteColleague2 : Colleague
    {

        /**
         * 
         */
        public ConcreteColleague2(Mediator mediator):base(mediator)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("ͬ�� 2 �õ� ��Ϣ " + message);
        }
    }
}