using ControlVentas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.BusinessLogicLayer
{
    public class LCustomer: IBusinessObject
    {
        public LCustomer()
        {
            telephoneNumbers = new List<string>();
        }
        public LCustomer(string name, string address, bool debtor) : this()
        {
            this.name = name;
            this.address = address;
            this.debtor = debtor;
        }

        public LCustomer(LCustomer customer)
            :this(customer.name,customer.address,customer.debtor)
        {
            telephoneNumbers = customer.getTelephoneNumbers();
        }
        private string name;
        private string address;
        private List<string> telephoneNumbers;
        private bool debtor;

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool Debtor { get { return debtor; } set { debtor = value; } }

        public void addTelephone(string telephone)
        {
            if (!string.IsNullOrEmpty(telephone))
            {
                telephoneNumbers.Add(telephone);
            }
        }

        public void setTelephoneNumbers(string formattedTelephoneNumbers)
        {
            string[] chainWithoutOpening = formattedTelephoneNumbers.Split('[');
            for (int i = 0; i < chainWithoutOpening.Length; i++)
            {
                string temp = chainWithoutOpening[i];
                if (!temp.Equals(""))
                    temp = temp.Remove(temp.Length - 1);
                chainWithoutOpening[i] = temp;
            }

            foreach (var item in chainWithoutOpening)
            {
                addTelephone(item);
            }
        }

        public string getFormattedTelephoneNumbers()
        {
            string telephoneNumbers = "";
            foreach (var item in this.telephoneNumbers)
            {
                telephoneNumbers += "[" + item + "]";
            }
            return telephoneNumbers;
        }

        public List<string> getTelephoneNumbers()
        {
            return telephoneNumbers;
        }

        public bool insert()
        {
            return new DCustomer().insert(this);
        }

        public bool update(IBusinessObject businessObject)
        {
            return new DCustomer().update(this, businessObject);
        }

        public bool delete()
        {
            return new DCustomer().delete(this);
        }

        public static List<IBusinessObject> searcher(string customerNameOrTelephone, bool inAllCustomers)
        {
            return new DCustomer().search(customerNameOrTelephone, inAllCustomers);
        }

        public List<IBusinessObject> select()
        {
            return new DCustomer().select();
        }

        public List<IBusinessObject> select(bool debtor)
        {
            return new DCustomer().select(debtor);
        }

        public override string ToString()
        {
            string result = $"name = {name}\naddress = {address} debtor = {debtor}";
            int i = 0;
            foreach (var item in telephoneNumbers)
            {
                result += $"\ntelefono {++i}: {item}";
            }
            return result;

        }

        public override bool Equals(object obj)
        {
            return obj is LCustomer customer &&
                   name == customer.name &&
                   address == customer.address &&
                   compareTelephoneNumbers(((LCustomer)obj).getTelephoneNumbers()) &&
                   debtor == customer.debtor &&
                   Name == customer.Name &&
                   Address == customer.Address &&
                   Debtor == customer.Debtor;
        }

        private bool compareTelephoneNumbers(List<string> list)
        {
            if (list.Count != telephoneNumbers.Count)
            {
                return false;
            }

            for (int i = 0; i < telephoneNumbers.Count; i++)
            {
                if (!telephoneNumbers[i].Equals(list[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 1472785787;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(telephoneNumbers);
            hashCode = hashCode * -1521134295 + debtor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + Debtor.GetHashCode();
            return hashCode;
        }
    }
}
