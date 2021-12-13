using LogibaProject.Businness.Abstract;
using LogibaProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using LogibaProject.Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Concrete
{
    public class GroupManager:IGroupService
    {
        private readonly IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public void Add(Entities.Concrete.Group group)
        {
            _groupDal.Add(group);
        }

        public void Delete(Expression<Func<Entities.Concrete.Group, bool>> filter)
        {
            _groupDal.Delete(filter);
        }

        public Entities.Concrete.Group Get(Expression<Func<Entities.Concrete.Group, bool>> filter)
        {
            return _groupDal.Get(filter);
        }

        public List<Entities.Concrete.Group> GetList(Expression<Func<Entities.Concrete.Group, bool>> filter)
        {
            return _groupDal.GetEntities(filter);
        }

        public void Update(Entities.Concrete.Group group)
        {
            _groupDal.Update(group);
        }
    }
}
