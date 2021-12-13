using LogibaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.Concrete
{
    public class Work:IEntity
    {
        public Work()
        {
            MapWorks = new List<MapWork>();
        }

        public int id { get; set; }
        public string Name { get; set; }
        public int No { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FileName { get; set; }
        public int Status { get; set; } // 1 => devam ediyor, 2 => bitti, 3 => durduruldu

        public virtual ICollection<MapWork> MapWorks { get; set; }
    }
}
