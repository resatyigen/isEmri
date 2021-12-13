using LogibaProject.Entities.StoredProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Businness.Abstract.StoredProcedure
{
    public interface IGetGroupsService
    {
        IEnumerable<GetGroups> GetGroups();
    }
}
