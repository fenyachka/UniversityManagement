using Management.Query.Interfaces;
using Management.Query.StudentQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Query.StudentQuery
{
    public class StudentListQuery : QueryBase<IEnumerable<StudentResponse>>
    {
        public override IEnumerable<StudentResponse> Action()
        {
            var students = UnitOfWork.Student.Table.Select(x => new StudentResponse
            {
                Id = x.Id,
                PrivateNumber = x.PrivateNumber,
                RegistrationDate = x.RegistrationDate
            });

            return students;
        }
    }
}
