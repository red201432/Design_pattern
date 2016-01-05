using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
<<<<<<< HEAD
     public class Context
    {
         private string input;
         public string Input { get; set; }
         private string output;
         public string Output { get; set; }
=======
    public class Context
    {
        private string input;
        public string Input { get { return input; } set { input = value; } }
        private string output;
        public string Output{get{return output;} set{output=value;}}
>>>>>>> 77e342ef6e96917a8dc01e72e41626dcffd4ba13
    }
}
