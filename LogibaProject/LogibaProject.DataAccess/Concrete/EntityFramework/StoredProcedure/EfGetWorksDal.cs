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
    public class EfGetWorksDal : IGetWorksDal
    {
        public IEnumerable<GetWorks> GetWorks(string type)
        {
            using (var context = new LogibaProjectContext())
            {
                var parameters = new object[]
                {
                    new SqlParameter("type",type)
                };
                return context.Database.SqlQuery<GetWorks>("exec SP_GetWorks @type", parameters).ToList();
            }
        }
    }
}
