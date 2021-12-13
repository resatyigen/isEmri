using LogibaProject.Core.DataAccess.EntityFramework;
using LogibaProject.DataAccess.Abstract;
using LogibaProject.DataAccess.Concrete.EntityFramework.Context;
using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Concrete.EntityFramework
{
    public class EfGroupDal : EfEntityRepositoryBase<Entities.Concrete.Group, LogibaProjectContext>, IGroupDal
    {
        protected override List<Entities.Concrete.Group> GetEntitiesAbstract(Expression<Func<Entities.Concrete.Group, bool>> filter, LogibaProjectContext context)
        {
            return filter == null
                ? context.Groups.ToList()
                : context.Groups.Where(filter).ToList();
        }

        protected override Entities.Concrete.Group GetEntityAbstract(Entities.Concrete.Group entity, LogibaProjectContext context)
        {
            throw new NotImplementedException();
        }

        protected override Entities.Concrete.Group GetEntityAbstract(Expression<Func<Entities.Concrete.Group, bool>> filter, LogibaProjectContext context)
        {
            return context.Groups.FirstOrDefault(filter);
        }
    }
}
