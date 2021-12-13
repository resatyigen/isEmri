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
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void Delete(Expression<Func<Admin, bool>> filter)
        {
            _adminDal.Delete(filter);
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            return _adminDal.Get(filter);
        }

        public List<Admin> GetList(Expression<Func<Admin, bool>> filter)
        {
            return _adminDal.GetEntities(filter);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
