using LogibaProject.Businness.Abstract.StoredProcedure;
using LogibaProject.DataAccess.Abstract.StoredProcedure;
using LogibaProject.Entities.StoredProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.StoredProcedure
{
    public class GetWorksManager : IGetWorksService
    {
        private readonly IGetWorksDal _getCommentsDal;

        public GetWorksManager(IGetWorksDal getCommentsDal)
        {
            _getCommentsDal = getCommentsDal;
        }

        public IEnumerable<GetWorks> GetWorks(string type)
        {
            return _getCommentsDal.GetWorks(type);
        }
    }
}
