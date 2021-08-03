using ControlVentas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.BusinessLogicLayer
{
    public class LUnpaidOrder : LOrder
    {
        private decimal remainder;
        private List<LAccumulatedAmount> accumulatedAmounts;

        public LUnpaidOrder()
            : base()
        {
            this.remainder = 0;
            accumulatedAmounts = new List<LAccumulatedAmount>();
        }


        public LUnpaidOrder(LOrder order, decimal remainder)
            : base(order)
        {
            this.remainder = remainder;
            accumulatedAmounts = new List<LAccumulatedAmount>();
        }

        public LUnpaidOrder(LUnpaidOrder unpaidOrder)
            : this(
                  new LOrder(unpaidOrder.ID,
                      unpaidOrder.Description,
                      unpaidOrder.Date,
                      unpaidOrder.Customer,
                      unpaidOrder.OrderDetail)
                  , unpaidOrder.Remainder)
        {
            accumulatedAmounts = unpaidOrder.accumulatedAmounts;
        }

        
        public decimal Remainder { get { return remainder; } set { remainder = value; } }

        public List<LAccumulatedAmount> AccumulatedAmounts { get { return accumulatedAmounts; } set { accumulatedAmounts = value; } }

        public override bool insert()
        {
            return new DUnpaidOrder().insert(this);
        }

        public override List<IBusinessObject> select()
        {
            return new DUnpaidOrder().select();
        }
        public List<IBusinessObject> select(LCustomer customer)
        {
            return select().Where(unpadiOrder => ((LUnpaidOrder)unpadiOrder).Customer.Equals(customer)).Cast<IBusinessObject>().ToList();
        }

        public override bool update(IBusinessObject updatedBusinessObject)
        {
            this.remainder = ((LUnpaidOrder)updatedBusinessObject).remainder;
            this.accumulatedAmounts = ((LUnpaidOrder)updatedBusinessObject).accumulatedAmounts;
            return new DUnpaidOrder().update(this, updatedBusinessObject);
        }
        public override bool delete()
        {
            return new DUnpaidOrder().delete(this);
        }

        public override string ToString()
        {
            return base.ToString()+$" REMAINDER={remainder} ACCUMULATED = {AccumulatedAmounts}";
        }
    }
}
