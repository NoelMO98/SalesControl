using ControlVentas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.BusinessLogicLayer
{
    public class LAccumulatedAmount
    {
        private decimal amount;
        private DateTime date;
        private int orderID;

        public LAccumulatedAmount()
        {
            amount = 0;
            date = DateTime.Now;
            orderID = 0;
        }
        public LAccumulatedAmount(int orderID, decimal amount, DateTime date) : this()
        {
            this.orderID = orderID;
            this.amount = amount;
            this.date = date;
        }

        public int OrderID { get { return this.orderID; } set { this.orderID = value; } }
        public decimal Amount { get { return this.amount; } set { this.amount = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }

        public bool insert()
        {
            return new DAccumulatedAmount().insert(this);
        }

        public List<LAccumulatedAmount> select(LUnpaidOrder unpaidOrder)
        {
            return new DAccumulatedAmount().select(unpaidOrder);
        }

    }
}
