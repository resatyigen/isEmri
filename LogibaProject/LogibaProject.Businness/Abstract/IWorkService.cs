using LogibaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract
{
    public interface IWorkService
    {
        List<Work> GetList(Expression<Func<Work, bool>> filter);

        Work Get(Expression<Func<Work, bool>> filter);

        void Add(Work work);

        void Delete(Expression<Func<Work, bool>> filter);

        void Update(Work work);
    }
}
