
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Mediator { 
/**
 * 
 */
    public class ConcreteColleague1 : Colleague
    {

        /**
         * 
         */
        public ConcreteColleague1(Mediator mediator):base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("ͬ�� 1 �õ� ��Ϣ " + message);
        }
    }
}