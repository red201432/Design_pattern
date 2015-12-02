using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public class GameRole
    {
        private string vit;
        private string atk;
        private string def;
        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(vit, atk, def));
        }
        public void GetInitState()
        {
            this.vit = "100";
            this.atk = "100";
            this.def = "100";
        }

        public void StateDisplay()
        {
            Console.WriteLine("Vit is :"+this.vit);
            Console.WriteLine("Atk is :" + this.atk);
            Console.WriteLine("Def is :" + this.def);
        }

        public void Fight()
        {
            this.vit = "0";
            this.atk = "0";
            this.def = "0";
        }
        public void RecoveryState(RoleStateMemento memento){
            this.vit=memento.Vit;
            this.atk=memento.Atk;
            this.def=memento.Def;
        }
        public string Vit { get { return vit; } set { vit = value; } }
        public string Atk { get { return atk; } set { atk = value; } }
        public string Def { get { return def; } set { def = value; } }
    }
}
