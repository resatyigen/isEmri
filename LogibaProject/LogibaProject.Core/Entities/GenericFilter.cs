using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.Core.Entities
{
    public class GenericFilter<T>
    {
        public Expression<Func<T, bool>> Filter { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public string Search { get; set; }
    }
}
