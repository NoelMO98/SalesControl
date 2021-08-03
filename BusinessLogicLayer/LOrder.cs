using ControlVentas.DataAccessLayer;
using ControlVentas.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.BusinessLogicLayer
{
    public class LOrder : IBusinessObject
    {
        protected int id;
        protected string description;
        protected DateTime date;
        protected LCustomer customer;
        protected LOrderDetail orderDetail;
        public LOrder()
        {
            this.orderDetail = new LOrderDetail();
        }

        public LOrder(string description, DateTime date, LCustomer customer) : this()
        {
            this.description = description;
            this.date = date;
            this.customer = customer;
        }

        public LOrder(int id, string description, DateTime date, LCustomer customer)
            : this(description,date,customer)
        {
            this.id = id;
        }

        public LOrder(string description, DateTime date, LCustomer customer, LOrderDetail orderDetail)
            : this(description, date, customer)
        {
            this.orderDetail = orderDetail;
        }   
        public LOrder(int id, string description, DateTime date, LCustomer customer, LOrderDetail orderDetail)
            : this(id,description, date, customer)
        {
            this.orderDetail = orderDetail;
        }

        public LOrder(LOrder order)
            : this(order.Description, order.Date, order.Customer, order.OrderDetail)
        {
            id = order.ID;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public LCustomer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public LOrderDetail OrderDetail
        {
            get { return orderDetail; }
            set { orderDetail = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is LOrder order &&
                   id == order.id &&
                   description == order.description &&
                   date == order.date &&
                   EqualityComparer<LCustomer>.Default.Equals(customer, order.customer) &&
                   EqualityComparer<LOrderDetail>.Default.Equals(orderDetail, order.orderDetail) &&
                   ID == order.ID &&
                   Description == order.Description &&
                   Date == order.Date &&
                   EqualityComparer<LCustomer>.Default.Equals(Customer, order.Customer) &&
                   EqualityComparer<LOrderDetail>.Default.Equals(OrderDetail, order.OrderDetail);
        }

        public override int GetHashCode()
        {
            int hashCode = 1923925322;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<LCustomer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<LOrderDetail>.Default.GetHashCode(orderDetail);
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<LCustomer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<LOrderDetail>.Default.GetHashCode(OrderDetail);
            return hashCode;
        }

        public override string ToString()
        {
            return "Order{ ID= " + ID + " Description= " + Description + " Date= " + Date.ToString() + " Customer= " + Customer + " orderDetail= " +
                OrderDetail + " }";
        }

        public virtual bool insert()
        {
            DOrder dOrder = new DOrder();
            if (dOrder.insert(this))
            {
                this.id = dOrder.getOrderID(this);
                return true;
            }
            return false;
        }

        public virtual bool update(IBusinessObject updatedBusinessObject)
        {
            this.customer = ((LOrder)updatedBusinessObject).customer;
            this.date = ((LOrder)updatedBusinessObject).date;
            this.description = ((LOrder)updatedBusinessObject).description;
            this.orderDetail = ((LOrder)updatedBusinessObject).orderDetail;
            return new DOrder().update(this, updatedBusinessObject);
        }

        public virtual bool delete()
        {
            return new DOrder().delete(this);
        }

        public virtual List<IBusinessObject> select()
        {
            return new DOrder().select();
        }

        public List<IBusinessObject> selectOrdersPaid()
        {
            return new DOrder().selectOrdersPaid();
        }

        public List<IBusinessObject> selectOrdersPaid(LCustomer customer)
        {
            return selectOrdersPaid().Where(orderPaid => ((LOrder)orderPaid).Customer.Equals(customer)).Cast<IBusinessObject>().ToList();
        }

        public static List<IBusinessObject> searcher(string parameter)
        {
            return new DOrder().search(parameter);
        }
    }

}
