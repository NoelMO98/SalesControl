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
    class DAccumulatedAmount
    {
        private SqlCommand command = new SqlCommand();
        private SqlDataReader dataReader = null;
        public bool insert(LAccumulatedAmount accumulatedAmount)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedured = "insert_accumulated_amount";
                command.CommandText = storedProcedured;
                command.Parameters.AddWithValue("@amount", accumulatedAmount.Amount);
                command.Parameters.AddWithValue("@date_accumulated_amount", accumulatedAmount.Date);
                command.Parameters.AddWithValue("@order_id", accumulatedAmount.OrderID);
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

        public List<LAccumulatedAmount> select(LUnpaidOrder unpaidOrder)
        {
            List<LAccumulatedAmount> accumulatedAmounts = new List<LAccumulatedAmount>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedured = "select_accumulated_amounts";
                command.CommandText = storedProcedured;
                command.Parameters.AddWithValue("@order_id", unpaidOrder.ID);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    decimal amount = (decimal)dataReader["amount"];
                    DateTime date = (DateTime)dataReader["date_accumulated_amount"];
                    int orderID = (int)dataReader["order_id"];

                    LAccumulatedAmount accumulatedAmount = new LAccumulatedAmount(orderID, amount, date);
                    accumulatedAmounts.Add(accumulatedAmount);
                }
                dataReader.Close();
                return accumulatedAmounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return accumulatedAmounts;
            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }
        }

        public void addAccumulatedAmountsToUnpaidOrders(List<IBusinessObject> unpaidOrders)
        {
            foreach (LUnpaidOrder unpaidOrder in unpaidOrders)
            {
                unpaidOrder.AccumulatedAmounts = select(unpaidOrder);
            }
        }
    }
}
