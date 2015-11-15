using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCore
{
    /// <summary>
    /// 打折子类
    /// </summary>
   public class CashRebate:CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate) {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * 0.8;
        }

    }
}
