using LogibaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Concrete
{
    public class Group:IEntity
    {
        public Group()
        {
            MapGroupUsers = new List<MapGroupUser>();
            MapWorks = new List<MapWork>();
        }

        public int id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MapGroupUser> MapGroupUsers { get; set; }
        public virtual ICollection<MapWork> MapWorks { get; set; }
    }
}
