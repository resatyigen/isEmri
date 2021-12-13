using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IMapGroupUserService
    {
        List<MapGroupUser> GetList(Expression<Func<MapGroupUser, bool>> filter);

        MapGroupUser Get(Expression<Func<MapGroupUser, bool>> filter);

        void Add(MapGroupUser mapGroupUser);

        void Delete(Expression<Func<MapGroupUser, bool>> filter);

        void Delete(MapGroupUser mapGroupUser);

        void Update(MapGroupUser mapGroupUser);
    }
}
