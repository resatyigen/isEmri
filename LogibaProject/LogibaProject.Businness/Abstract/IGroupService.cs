using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IGroupService
    {
        List<Group> GetList(Expression<Func<Group, bool>> filter);

        Group Get(Expression<Func<Group, bool>> filter);

        void Add(Group group);

        void Delete(Expression<Func<Group, bool>> filter);

        void Update(Group group);
    }
}
