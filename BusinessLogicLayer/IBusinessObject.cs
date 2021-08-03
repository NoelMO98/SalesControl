using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.BusinessLogicLayer
{
    public interface IBusinessObject
    {
        bool insert();
        bool update(IBusinessObject businessObject);
        bool delete();
        List<IBusinessObject> select();
    }
}
