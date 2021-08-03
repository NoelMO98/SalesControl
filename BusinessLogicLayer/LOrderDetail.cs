using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.BusinessLogicLayer
{
    public class LOrderDetail
    {
        private decimal priceKilo;
        private decimal weight;
        private bool exactAmount;
        private decimal amount;

        public decimal PriceKilo { get { return priceKilo; } set { priceKilo = value; } }
        public decimal Weight { get { return weight; } set { weight = value; } }
        public bool ExactAmount { get { return exactAmount; } set { exactAmount = value; } }
        public decimal Amount { get { return amount; } set { amount = value; } }

        public LOrderDetail()
        {
            priceKilo = 0;
            weight = 0;
            exactAmount = false;
            amount = 0;
        }

        public LOrderDetail(decimal priceKilo, decimal weight, bool exactAmount, decimal amount):this()
        {
            PriceKilo = priceKilo;
            Weight = weight;
            ExactAmount = exactAmount;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Sale{ priceKilo = "+PriceKilo+" weight = "+Weight+" exactAmount = " +
               ExactAmount+" amount = "+Amount+"}";
        }

        public override bool Equals(object obj)
        {
            return obj is LOrderDetail detail &&
                   priceKilo == detail.priceKilo &&
                   weight == detail.weight &&
                   exactAmount == detail.exactAmount &&
                   amount == detail.amount;
        }

        public override int GetHashCode()
        {
            int hashCode = 763343981;
            hashCode = hashCode * -1521134295 + priceKilo.GetHashCode();
            hashCode = hashCode * -1521134295 + weight.GetHashCode();
            hashCode = hashCode * -1521134295 + exactAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + amount.GetHashCode();
            return hashCode;
        }
    }
}
