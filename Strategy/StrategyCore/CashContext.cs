using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCore
{
   public class CashContext
    {
        private CashSuper cs;
        public CashContext(CashSuper cashSuper) {
            this.cs = cashSuper;
        }

        public double GetResult(double money) {
            return cs.acceptCash(money);
        }
    }
}
