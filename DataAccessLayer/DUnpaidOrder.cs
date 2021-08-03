using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.DataAccessLayer
{
    public class DUnpaidOrder : IDataAccess
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
                string storedProcedured = "insert_unpaid_order";
                command.CommandText = storedProcedured;
                command.Parameters.AddWithValue("@remainder", ((LUnpaidOrder)businessObject).Remainder);
                command.Parameters.AddWithValue("@order_id", ((LOrder)businessObject).ID);
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

        public bool update(IBusinessObject businessObject, IBusinessObject updatedBusinessObject)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                string storedProcedure = "update_unpaid_order";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@order_id", ((LUnpaidOrder)businessObject).ID);
                command.Parameters.AddWithValue("@remainder", ((LUnpaidOrder)updatedBusinessObject).Remainder);
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
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedure = "delete_unpaid_order";
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@order_id", ((LUnpaidOrder)businessObject).ID);
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
            List<IBusinessObject> unpaidOrders = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "select_unpaid_orders";
                dataReader = command.ExecuteReader();
                List<LCustomer> customers = new List<LCustomer>();
                while (dataReader.Read())
                {
                    int orderID = (int)dataReader["order_id"];
                    DateTime orderDate = (DateTime)dataReader["order_date"];
                    string orderDescription = dataReader["order_description"].ToString();
                    LOrderDetail orderDetail = new LOrderDetail();
                    orderDetail.Amount = (decimal)dataReader["order_amount"];
                    string customerName = dataReader["customer_name"].ToString();
                    string customerAddress = dataReader["customer_address"].ToString();
                    bool customerDebtor = true;
                    decimal remainder = (decimal)dataReader["remainder"];
                    LCustomer customer = new LCustomer(customerName, customerAddress, customerDebtor);
                    LOrder order = new LOrder(orderID, orderDescription, orderDate, customer,orderDetail);
                    LUnpaidOrder unpaidOrder = new LUnpaidOrder(order, remainder);
                    customers.Add(customer);
                    unpaidOrders.Add(unpaidOrder);
                }
                dataReader.Close();
                new DCustomer().addTelephoneNumbersToCustomers(customers.Cast<IBusinessObject>().ToList());
                new DAccumulatedAmount().addAccumulatedAmountsToUnpaidOrders(unpaidOrders);
                return unpaidOrders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return unpaidOrders;
            }
            finally
            {
                Connection.close();
            }
        }
    }
}
