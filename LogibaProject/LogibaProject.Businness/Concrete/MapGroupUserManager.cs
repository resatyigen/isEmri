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
    public class MapGroupUserManager : IMapGroupUserService
    {
        private readonly IMapGroupUserDal _mapGroupUserDal;

        public MapGroupUserManager(IMapGroupUserDal mapGroupUserDal)
        {
            _mapGroupUserDal = mapGroupUserDal;
        }

        public void Add(MapGroupUser mapGroupUser)
        {
            _mapGroupUserDal.Add(mapGroupUser);
        }

        public void Delete(Expression<Func<MapGroupUser, bool>> filter)
        {
            _mapGroupUserDal.Delete(filter);
        }

        public void Delete(MapGroupUser mapGroupUser)
        {
            _mapGroupUserDal.Delete(mapGroupUser);
        }

        public MapGroupUser Get(Expression<Func<MapGroupUser, bool>> filter)
        {
            return _mapGroupUserDal.Get(filter);
        }

        public List<MapGroupUser> GetList(Expression<Func<MapGroupUser, bool>> filter)
        {
            return _mapGroupUserDal.GetEntities(filter);
        }

        public void Update(MapGroupUser mapGroupUser)
        {
            _mapGroupUserDal.Update(mapGroupUser);
        }
    }
}
