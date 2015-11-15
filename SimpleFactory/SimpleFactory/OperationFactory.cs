using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public  class OperationFactory
    {
        public static Opration createOperation(string operation) {
            Opration oper = null;
            switch (operation) { 
                case "+":
                    oper= new AddOperation();
                    break;
                case "-":
                    oper= new SubOperation();
                    break;
                case "*":
                    oper= new MulOperation();
                    break;
                case "/":
                    oper=new DivOperation();
                    break;
            }
            return oper;
        }
    }
}
