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
    public class GetGroupsManager : IGetGroupsService
    {
        private readonly IGetGroupsDal _getGroupsDal;

        public GetGroupsManager(IGetGroupsDal getGroupsDal)
        {
            _getGroupsDal = getGroupsDal;
        }

        public IEnumerable<GetGroups> GetGroups()
        {
            return _getGroupsDal.GetGroups();
        }
    }
}
