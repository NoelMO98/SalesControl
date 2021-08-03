using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data; //
using System.Data.SqlClient; //
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.DataAccessLayer
{
    public class DOrder : IDataAccess
    {
        private SqlCommand command = new SqlCommand();
        private SqlDataReader dataReader = null;

        public bool insert(IBusinessObject businessObject)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedured = "insert_order";
                command.CommandText = storedProcedured;
                command.Parameters.AddWithValue("@order_date", ((LOrder)businessObject).Date);
                command.Parameters.AddWithValue("@order_description", ((LOrder)businessObject).Description);
                command.Parameters.AddWithValue("@order_amount", ((LOrder)businessObject).OrderDetail.Amount);
                command.Parameters.AddWithValue("@customer_name", ((LOrder)businessObject).Customer.Name);
                command.Parameters.AddWithValue("@customer_address", ((LOrder)businessObject).Customer.Address);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }
        }

        public int getOrderID(LOrder order)
        {
            int id;
            do
            {
                id = orderID(order);
            } while (id == -1);
            return id;
        }

        private int orderID(LOrder order)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.Text;
                string sqlQuery = "select order_id from ORDERS where order_date=@date and order_description=@description and customer_name=@customer and customer_address=@address";
                command.CommandText = sqlQuery;
                command.Parameters.AddWithValue("@date", order.Date);
                command.Parameters.AddWithValue("@description", order.Description);
                command.Parameters.AddWithValue("@customer", order.Customer.Name);
                command.Parameters.AddWithValue("@address", order.Customer.Address);

                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }
        }

        public bool update(IBusinessObject businessObject, IBusinessObject updatedBusinessObject)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                string storedProcedure = "update_order";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@order_id", ((LOrder)businessObject).ID);
                command.Parameters.AddWithValue("@order_date", ((LOrder)updatedBusinessObject).Date);
                command.Parameters.AddWithValue("@order_description", ((LOrder)updatedBusinessObject).Description);
                command.Parameters.AddWithValue("@order_amount", ((LOrder)updatedBusinessObject).OrderDetail.Amount);
                command.Parameters.AddWithValue("@customer_name", ((LOrder)updatedBusinessObject).Customer.Name);
                command.Parameters.AddWithValue("@customer_address", ((LOrder)updatedBusinessObject).Customer.Address);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }
        }

        public bool delete(IBusinessObject businessObject)
        {
            LOrder order = (LOrder)businessObject;
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedure = "delete_order";
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@order_id", order.ID);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }
        }

        public List<IBusinessObject> select()
        {
            List<IBusinessObject> orders = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "select_orders";
                dataReader = command.ExecuteReader();
                List<LCustomer> customers = new List<LCustomer>();
                while (dataReader.Read())
                {
                    int orderID = (int)dataReader["order_id"];
                    DateTime orderDate = (DateTime)dataReader["order_date"];
                    string orderDescription = dataReader["order_description"].ToString();
                    string customerName = dataReader["customer_name"].ToString();
                    string customerAddress = dataReader["customer_address"].ToString();
                    bool customerDebtor = string.IsNullOrEmpty(dataReader["customer_status"].ToString()) ? false : (bool)dataReader["customer_status"];
                    LCustomer customer = new LCustomer(customerName, customerAddress, customerDebtor);
                    LOrder order = new LOrder(orderID, orderDescription, orderDate, customer);
                    customers.Add(customer);
                    orders.Add(order);
                }
                dataReader.Close();
                new DCustomer().addTelephoneNumbersToCustomers(customers.Cast<IBusinessObject>().ToList());
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return orders;
            }
            finally
            {
                Connection.close();
            }
        }

        public List<IBusinessObject> selectOrdersPaid()
        {
            List<IBusinessObject> orders = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "select_orders_paid";
                dataReader = command.ExecuteReader();
                List<LCustomer> customers = new List<LCustomer>();
                while (dataReader.Read())
                {
                    int orderID = (int)dataReader["order_id"];
                    DateTime orderDate = (DateTime)dataReader["order_date"];
                    string orderDescription = dataReader["order_description"].ToString();
                    decimal amount = (decimal)dataReader["order_amount"];
                    string customerName = dataReader["customer_name"].ToString();
                    string customerAddress = dataReader["customer_address"].ToString();
                    bool customerDebtor = string.IsNullOrEmpty(dataReader["customer_status"].ToString()) ? false : (bool)dataReader["customer_status"];
                    LCustomer customer = new LCustomer(customerName, customerAddress, customerDebtor);
                    LOrderDetail orderDetail = new LOrderDetail();
                    orderDetail.Amount = amount;
                    LOrder order = new LOrder(orderID, orderDescription, orderDate, customer, orderDetail);
                    customers.Add(customer);
                    orders.Add(order);
                }
                dataReader.Close();
                new DCustomer().addTelephoneNumbersToCustomers(customers.Cast<IBusinessObject>().ToList());
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return orders;
            }
            finally
            {
                Connection.close();
            }
        }

        public List<IBusinessObject> search(string parameter)
        {
            List<IBusinessObject> orders = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedure = "search_customer_order";
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@searcher", parameter);
                dataReader = command.ExecuteReader();
                List<LCustomer> customers = new List<LCustomer>();
                while (dataReader.Read())
                {
                    int orderID = (int)dataReader["order_id"];
                    DateTime orderDate = (DateTime)dataReader["order_date"];
                    string orderDescription = dataReader["order_description"].ToString();
                    string customerName = dataReader["customer_name"].ToString();
                    string customerAddress = dataReader["customer_address"].ToString();
                    bool customerDebtor = string.IsNullOrEmpty(dataReader["customer_status"].ToString()) ? false : (bool)dataReader["customer_status"];
                    LCustomer customer = new LCustomer(customerName, customerAddress, customerDebtor);
                    LOrder order = new LOrder(orderID, orderDescription, orderDate, customer);
                    customers.Add(customer);
                    orders.Add(order);
                }
                dataReader.Close();
                new DCustomer().addTelephoneNumbersToCustomers(customers.Cast<IBusinessObject>().ToList());
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return orders;
            }
            finally
            {
                Connection.close();
            }
        }
    }
}
