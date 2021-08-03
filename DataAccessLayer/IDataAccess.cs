using ControlVentas.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DataAccessLayer
{
    public interface IDataAccess
    {
        bool insert(IBusinessObject businessObject);
        bool update(IBusinessObject businessObject, IBusinessObject updatedBusinessObject);
        bool delete(IBusinessObject businessObject);
        List<IBusinessObject> select();
    }
}
