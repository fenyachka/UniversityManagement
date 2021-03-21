using Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        int Complete();
        IRepository<Student> Student { get; }
        IRepository<Course> Course { get; }
        IRepository<CourseRegistrations> CourseRegistrations { get; }
        IRepository<Lecturer> Lecturer { get; }
        IRepository<Log> Log { get; }

    }
}
