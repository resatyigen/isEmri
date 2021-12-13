using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Entities.StoredProcedure
{
    public class GetWorks
    {
        public int MapId { get; set; }
        public int WorkId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public string WorkName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
    }
}
