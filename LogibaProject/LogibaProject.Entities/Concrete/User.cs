using LogibaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Concrete
{
    public class User:IEntity
    {
        public User()
        {
            MapWorks = new List<MapWork>();
            MapGroupUsers = new List<MapGroupUser>();
        }

        public int id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<MapWork> MapWorks { get; set; }
        public virtual ICollection<MapGroupUser> MapGroupUsers { get; set; }
    }
}
