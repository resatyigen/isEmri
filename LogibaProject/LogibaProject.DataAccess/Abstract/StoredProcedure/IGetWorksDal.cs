using LogibaProject.Entities.StoredProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Abstract.StoredProcedure
{
    public interface IGetWorksDal
    {
        IEnumerable<GetWorks> GetWorks(string type);
    }
}
