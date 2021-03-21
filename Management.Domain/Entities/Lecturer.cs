using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entities
{
    public class Lecturer:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public  ICollection<Course> Courses { get; set; }

    }
}
