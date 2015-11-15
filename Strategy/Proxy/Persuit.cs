using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public  class Persuit:GiveGift
    {
       SchoolGirl sg = new SchoolGirl();
       string name;
       public string Name { get; set; }
       public Persuit(SchoolGirl sg) {
           this.sg = sg;
       }
       public void GiveDolls() {
           Console.Write(sg.name+" get Dolls");
       }
       public void GiveFlowers() {
           Console.Write(sg.name + " get Flowers");
       }
    }
}
