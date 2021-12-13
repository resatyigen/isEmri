using LogibaProject.Businness.Abstract;
using LogibaProject.DataAccess.Abstract;
using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Concrete
{
    public class MapWork : IMapWorkService
    {
        private readonly IMapWorkDal _mapWorkDal;

        public MapWork(IMapWorkDal mapWorkDal)
        {
            _mapWorkDal = mapWorkDal;
        }

        public void Add(Entities.Concrete.MapWork mapWork)
        {
            _mapWorkDal.Add(mapWork);
        }

        public void Delete(Expression<Func<Entities.Concrete.MapWork, bool>> filter)
        {
            _mapWorkDal.Delete(filter);
        }

        public Entities.Concrete.MapWork Get(Expression<Func<Entities.Concrete.MapWork, bool>> filter)
        {
            return _mapWorkDal.Get(filter);
        }

        public List<Entities.Concrete.MapWork> GetList(Expression<Func<Entities.Concrete.MapWork, bool>> filter)
        {
            return _mapWorkDal.GetEntities(filter);
        }

        public void Update(Entities.Concrete.MapWork mapWork)
        {
            _mapWorkDal.Update(mapWork);
        }
    }
}
