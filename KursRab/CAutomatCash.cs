using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursRab
{
    class CAutomatCash
    {
        public double AutomatMoneyBox { get; set; }
        public double CashBox { get; set; }
        public CAutomatCash()
        {
            this.AutomatMoneyBox = 0;
            this.CashBox = 0;
        }
        public CAutomatCash(double AutomatMoney, double cashbox)
        {
            this.AutomatMoneyBox = AutomatMoney;
            this.CashBox = cashbox;
        }
        public double Return_Money()
        {
            double bufCashBox = CashBox;
            CashBox = 0;
            return bufCashBox;
        }
        public double Return_Remaining_Money(double Price)
        {
            if(Price_CashBox_Difference(Price)>=0)
                if (AutomatMoneyBox - (CashBox - Price) >= 0)
                {
                    AutomatMoneyBox -= (CashBox - Price);
                    return CashBox - Price;
                }
            return -1;
        }
        public double Price_CashBox_Difference(double Price)
        {
            return CashBox - Price;
        }
    }
}
