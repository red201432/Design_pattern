using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public class RoleStateManager
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
