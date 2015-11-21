using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public  class AccessUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 Access 数据库中为 User表添加了一条记录。");
        }
        public User GetUser(int id)
        {
            Console.WriteLine("从 Access 数据库中取出 id 值 为 id的 记录。");
            return null;
        }
    }
}
