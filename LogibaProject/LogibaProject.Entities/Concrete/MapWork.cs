using LogibaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Concrete
{
    public class MapWork:IEntity
    {
        public int id { get; set; }
        public int WorkId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }

        public virtual Work Work { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
    }
}
