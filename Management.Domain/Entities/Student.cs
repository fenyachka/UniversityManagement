using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entities
{
    public class Student: BaseEntity
    {
        public string PrivateNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public IList<CourseRegistrations> CourseRegistrations { get; set; }
    }
}
