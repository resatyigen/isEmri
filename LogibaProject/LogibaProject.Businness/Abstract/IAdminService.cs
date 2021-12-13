using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList(Expression<Func<Admin, bool>> filter);

        Admin Get(Expression<Func<Admin, bool>> filter);

        void Add(Admin admin);

        void Delete(Expression<Func<Admin, bool>> filter);

        void Update(Admin admin);
    }
}
