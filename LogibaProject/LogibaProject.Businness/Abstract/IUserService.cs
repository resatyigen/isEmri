using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IUserService
    {
        List<User> GetList(Expression<Func<User, bool>> filter);

        User Get(Expression<Func<User, bool>> filter);

        void Add(User user);

        void Delete(Expression<Func<User, bool>> filter);

        void Update(User user);
    }
}
