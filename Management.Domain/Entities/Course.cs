using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entities
{
    public class Course:BaseEntity
    {
        public string Coursename { get; set; }
        public string Description { get; set; }
        public bool IsForeign { get; set; } 
        public IList<CourseRegistrations> CourseRegistrations { get; set; }
        public int LecturerId { get; set; }
        public  Lecturer Lecturer { get; set; }
    }
}
