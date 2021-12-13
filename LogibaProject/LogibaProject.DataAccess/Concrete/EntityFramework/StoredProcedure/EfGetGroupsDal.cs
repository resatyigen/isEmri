using LogibaProject.DataAccess.Abstract.StoredProcedure;
using LogibaProject.DataAccess.Concrete.EntityFramework.Context;
using LogibaProject.Entities.StoredProcedure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Concrete.EntityFramework.StoredProcedure
{
    public class EfGetGroupsDal : IGetGroupsDal
    {
        public IEnumerable<GetGroups> GetGroups()
        {
            using(var context = new LogibaProjectContext())
            {
                return context.Database.SqlQuery<GetGroups>("exec SP_GetGroups").ToList();
            }
        }
    }
}
