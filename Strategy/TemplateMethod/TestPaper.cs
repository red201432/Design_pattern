using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 模板方法通过将不变的方法搬移到父类，去除了子类中的重复代码
    /// 当不变的和可变的行为在方法的子类实现中混合在一起的时候，不变的行为就会在子类中重复出现。我们通过模板方法把这些行为搬移到单一的地方，这样就帮组子类摆脱重复的不变行为的纠缠。
    /// 将变化的行为转移到子类实现，将不变的行为封装在父类之中，减少重复代码
    /// </summary>
    public abstract class TestPaper
    {
        public void Test1()
        {
            Console.WriteLine("炼成倚天剑、屠龙刀的玄铁可能是：【】\n a 球磨铸铁   b 马口铁   c 高速合金钢    d 碳素纤维");
            Console.WriteLine("Answer is :" + Answer1());
        }
        public void Test2()
        {
            Console.WriteLine("杨过、程英 、陆无双铲除了情花，造成【】 \n a 使这种植物不再害人 b 是一种珍贵植物灭绝 c 破坏了那个生态圈的平衡  d 造成该地区沙漠化");
            Console.WriteLine("Answer is :"+Answer2());
        }

        public abstract string Answer1();
        public abstract string Answer2();
    }
}
