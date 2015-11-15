using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Opration oper = OperationFactory.createOperation("+");
            oper.NumberA = 45;
            oper.NumberB = 54;
            Console.WriteLine(oper.GetResult());
        }
    }
}
