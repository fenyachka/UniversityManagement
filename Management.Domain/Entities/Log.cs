using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entities
{
    public class Log:BaseEntity
    {
        public string ActionType { get; set; }
        public string Data { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
