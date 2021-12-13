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
    public class EfMapWorkDal : EfEntityRepositoryBase<MapWork, LogibaProjectContext>, IMapWorkDal
    {
        protected override List<MapWork> GetEntitiesAbstract(Expression<Func<MapWork, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.MapWork.Include("MapWork").ToList()
                : context.MapWork.Where(filter).ToList();
        }

        protected override MapWork GetEntityAbstract(MapWork entity, LogibaProjectContext context)
        {
            throw new NotImplementedException();
        }

        protected override MapWork GetEntityAbstract(Expression<Func<MapWork, bool>> filter, LogibaProjectContext context)
        {
            return context.MapWork.FirstOrDefault(filter);
        }
    }
}
