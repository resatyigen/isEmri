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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(Expression<Func<User, bool>> filter)
        {
            _userDal.Delete(filter);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public List<User> GetList(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetEntities(filter);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
