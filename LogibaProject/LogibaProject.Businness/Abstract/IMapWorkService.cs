using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IMapWorkService
    {
        List<MapWork> GetList(Expression<Func<MapWork, bool>> filter);

        MapWork Get(Expression<Func<MapWork, bool>> filter);

        void Add(MapWork mapWork);

        void Delete(Expression<Func<MapWork, bool>> filter);

        void Update(MapWork mapWork);
    }
}
