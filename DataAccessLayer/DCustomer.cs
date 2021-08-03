using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ControlVentas.BusinessLogicLayer;
using System.Windows.Forms;
using System.Data;

namespace ControlVentas.DataAccessLayer
{
    public class DCustomer: IDataAccess
    {
        private SqlCommand command = new SqlCommand();
        private SqlDataReader dataReader = null;

        public bool insert(IBusinessObject businessObject)
        {
            LCustomer customer = (LCustomer)businessObject;
            bool wasInserted = insertCustomer(customer);
            if (!wasInserted)
            {
                return false;
            }
            bool result = wasInserted && insertTelephoneNumbers(customer);
            if (!result)
            {
                bool wasDeleted;
                do
                {
                    wasDeleted = delete(customer) && deleteTelephoneNumbers(customer) >= 0;
                } while (!wasDeleted);
            }

            return result;
        }

        private bool insertCustomer(LCustomer customer)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                string storedProcedure = "insert_customer";
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@customer_name", customer.Name);
                command.Parameters.AddWithValue("@customer_address", customer.Address);
                command.Parameters.AddWithValue("@customer_status", customer.Debtor ? 1 : 0);
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

        private bool insertTelephoneNumbers(LCustomer customer)
        {
            List<string> telephoneNumbers = new List<string>();
            telephoneNumbers = customer.getTelephoneNumbers();
            bool result = true;
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.Text;
                string sqlQuery = "insert into TELEPHONES values(@name,@address,@number)";
                command.CommandText = sqlQuery;
                foreach (var telephoneNumber in telephoneNumbers)
                {
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@address", customer.Address);
                    command.Parameters.AddWithValue("@number", telephoneNumber);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                    command.Parameters.Clear();
                }
                return result;
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
            LCustomer customer = (LCustomer)businessObject;
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.Text;
                string sqlQuery = "delete from CUSTOMERS where customer_name=@name and customer_address=@address";
                command.CommandText = sqlQuery;
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@address", customer.Address);
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

        private int deleteTelephoneNumbers(LCustomer customer)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.Text;
                string sqlQuery = "delete from TELEPHONES where customer_name=@name and customer_address=@address";
                command.CommandText = sqlQuery;
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@address", customer.Address);
                return command.ExecuteNonQuery();
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
            LCustomer oldCustomer = (LCustomer)businessObject;
            LCustomer newCustomer = (LCustomer)updatedBusinessObject;
            bool wasUpdated = true;
            if (!updateCustomer(oldCustomer, newCustomer))
            {
                return false;
            }
            if (!updateTelephoneNumbers(oldCustomer, newCustomer))
            {
                bool backToNormal;
                do
                {
                    backToNormal = updateCustomer(newCustomer, oldCustomer);
                } while (!backToNormal);
                wasUpdated = false;
            }
            return wasUpdated;
        }

        private bool updateCustomer(LCustomer oldCustomer, LCustomer newCustomer)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                string sqlQuery = "update CUSTOMERS set customer_name =@name, customer_address=@address, customer_status=@status where customer_name=@oldName and customer_address=@oldAddress";
                command.CommandText = sqlQuery;
                command.Parameters.AddWithValue("@name", newCustomer.Name);
                command.Parameters.AddWithValue("@address", newCustomer.Address);
                command.Parameters.AddWithValue("@status", newCustomer.Debtor);
                command.Parameters.AddWithValue("@oldName", oldCustomer.Name);
                command.Parameters.AddWithValue("@oldAddress", oldCustomer.Address);
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

        public bool updateTelephoneNumbers(LCustomer oldCustomer, LCustomer newCustomer)
        {
            int resultSelectTelephoneNumbers;
            do
            {
                resultSelectTelephoneNumbers = selectTelephoneNumbers(newCustomer);
            } while (resultSelectTelephoneNumbers == -1);
            if (resultSelectTelephoneNumbers > 0)
            {
                int wereDeleted;
                do
                {
                    wereDeleted = deleteTelephoneNumbers(newCustomer);
                }while(wereDeleted == -1);
            }
            if (!insertTelephoneNumbers(newCustomer))
            {
                bool backToNormal;
                do
                {
                    backToNormal = insertTelephoneNumbers(oldCustomer);
                } while (!backToNormal);
                return false;
            }
            return true;
        }

        private int selectTelephoneNumbers(LCustomer customer)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                string sqlQuery = "select * from TELEPHONES where customer_name=@name and customer_address=@address";
                command.CommandType = CommandType.Text;
                command.CommandText = sqlQuery;
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@address", customer.Address);
                dataReader = command.ExecuteReader();
                int rows = 0;
                while (dataReader.Read())
                {
                    rows++;
                }
                return rows;
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

        public List<IBusinessObject> select()
        {
            List<IBusinessObject> customers;
            bool result;
            do
            {
                customers = selectCustomers("select_customers");
                result = addTelephoneNumbersToCustomers(customers);
            } while (!result);

            return customers;
        }

        public List<IBusinessObject> select(bool debtor)
        {
            List<IBusinessObject> customers;
            bool result;
            do
            {
                customers = selectCustomers(debtor ? "select_irregular_customers" : "select_regular_customers");
                result = addTelephoneNumbersToCustomers(customers);
            } while (!result);

            return customers;
        }


        private List<IBusinessObject> selectCustomers(string storedProcedure)
        {
            List<IBusinessObject> customers = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedure;
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader["customer_name"].ToString();
                    string address = dataReader[1].ToString();
                    bool debtor = string.IsNullOrEmpty(dataReader["customer_status"].ToString()) ? false : (bool)dataReader["customer_status"];
                    LCustomer customer = new LCustomer(name, address, debtor);
                    customers.Add(customer);
                }
                dataReader.Close();
                return customers;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return customers;
            }
            finally
            {
                Connection.close();
            }
        }

        internal bool addTelephoneNumbersToCustomers(List<IBusinessObject> customers)
        {
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.Text;

                foreach (var customer in customers)
                {
                    string sqlQuery = "Select number from TELEPHONES where customer_name=@name and customer_address=@address";
                    command.CommandText = sqlQuery;
                    command.Parameters.AddWithValue("@name", ((LCustomer)customer).Name);
                    command.Parameters.AddWithValue("@address", ((LCustomer)customer).Address);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ((LCustomer)customer).addTelephone(dataReader["number"].ToString());
                    }
                    dataReader.Close();
                    command.Parameters.Clear();
                }
                return true;
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

        public List<IBusinessObject> search(string customerNameOrTelephone, bool inAllCustomers)
        {
            List<IBusinessObject> customers;
            bool result;
            do
            {
                customers = searchCustomer(inAllCustomers? "search_in_all_customers": "search_regular_or_irregular_customer", customerNameOrTelephone);
                result = addTelephoneNumbersToCustomers(customers);
            } while (!result);

            return customers;
        }

        private List<IBusinessObject> searchCustomer(string storedProcedure, string customerNameOrTelephone)
        {
            List<IBusinessObject> customers = new List<IBusinessObject>();
            try
            {
                Connection.open();
                command.Connection = Connection.connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedure;
                command.Parameters.AddWithValue("@searcher", customerNameOrTelephone);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader["customer_name"].ToString();
                    string address = dataReader[1].ToString();
                    bool debtor = string.IsNullOrEmpty(dataReader["customer_status"].ToString()) ? false : (bool)dataReader["customer_status"];
                    LCustomer customer = new LCustomer(name, address, debtor);
                    if (!customers.Contains(customer))
                    {
                        customers.Add(customer);
                    }
                }
                dataReader.Close();
                return customers;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return customers;
            }
            finally
            {
                Connection.close();
                command.Parameters.Clear();
            }

        }
    }
}
