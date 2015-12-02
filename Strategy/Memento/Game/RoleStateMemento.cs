using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public class RoleStateMemento
    {
        private string vit;
        private string atk;
        private string def;
        public RoleStateMemento(string vit, string atk, string def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        public string Vit { get { return vit; } set { vit = value; } }
        public string Atk { get { return atk; }set {atk=value; }}
        public string Def { get { return def; } set {def=value;} }
    }
}
