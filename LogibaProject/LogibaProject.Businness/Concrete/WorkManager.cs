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
    public class WorkManager : IWorkService
    {
        private readonly IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public void Add(Work work)
        {
            _workDal.Add(work);
        }

        public void Delete(Expression<Func<Work, bool>> filter)
        {
            _workDal.Delete(filter);
        }

        public Work Get(Expression<Func<Work, bool>> filter)
        {
            return _workDal.Get(filter);
        }

        public List<Work> GetList(Expression<Func<Work, bool>> filter)
        {
            return _workDal.GetEntities(filter);
        }

        public void Update(Work work)
        {
            _workDal.Update(work);
        }
    }
}
