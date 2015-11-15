using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
   public  class Resume:ICloneable
    {
       private string name;
       private string sex;
       private string age;
       //private string timeArea;
       //private string company;
       WorkExperience work;
       public Resume(string name)
       {
           this.name = name;
           work = new WorkExperience();
       }

       private Resume(WorkExperience work) {
           this.work = (WorkExperience)work.Clone();//提供Clone方法调用的私有构造函数，以便克隆“工作经历”的数据
       }
       public void setInfo(string sex, string age) {
           this.age = age;
           this.sex = sex;
       }

       public void setWorkExperience(string timearea,string company )
       {
           work.WorkDate = timearea;
           work.Company = company;
       }


       public void display()
       {
           Console.WriteLine(name+" "+sex+" "+age);
           Console.WriteLine("工作经历:"+work.WorkDate+":"+work.Company);
       }
       public Object Clone()//进行深拷贝
       {
           Resume obj = new Resume(this.work);//调用私有的构造方法，让“工作经历“克隆完成，然后在给这个”简历”对象的相关字段赋值，最终返回一个深复制的对象
           obj.name = this.name;
           obj.sex = this.sex;
           obj.age = this.age; 
           return obj;
       }
    }
}
