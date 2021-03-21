using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Query.StudentQuery.Models
{
    public class StudentResponse
    {
        public int Id { get; set; }
        public string  PrivateNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
