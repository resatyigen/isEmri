using LogibaProject.Core.DataAccess.EntityFramework;
using LogibaProject.DataAccess.Abstract;
using LogibaProject.DataAccess.Concrete.EntityFramework.Context;
using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Concrete.EntityFramework
{
    public class EfMapGroupUserDal : EfEntityRepositoryBase<MapGroupUser, LogibaProjectContext>, IMapGroupUserDal
    {
        protected override List<MapGroupUser> GetEntitiesAbstract(Expression<Func<MapGroupUser, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.MapGroupUser.ToList()
                : context.MapGroupUser.Where(filter).ToList();
        }

        protected override MapGroupUser GetEntityAbstract(MapGroupUser entity, LogibaProjectContext context)
        {
            throw new NotImplementedException();
        }

        protected override MapGroupUser GetEntityAbstract(Expression<Func<MapGroupUser, bool>> filter, LogibaProjectContext context)
        {
            return context.MapGroupUser.FirstOrDefault(filter);
        }
    }
}
