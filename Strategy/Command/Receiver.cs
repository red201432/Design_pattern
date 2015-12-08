using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Receiver
    {
        /// <summary>
        /// 知道任何实施与执行一个与请求相关的操作，任何类都可以作为一个接受者。
        /// 
        /// </summary>
        public void Action()
        {
            Console.WriteLine("执行请求！");
        }
    }
}
