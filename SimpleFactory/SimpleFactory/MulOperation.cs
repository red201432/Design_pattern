﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class MulOperation:Opration
    {
        public override double GetResult()
{
    double result = 0;
    result = NumberA * NumberB;
    return result;
}
         
    }
}
