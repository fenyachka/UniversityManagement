using Management.Domain.Entities;
using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<Student> Student { get; }

        public IRepository<Course> Course { get; }

        public IRepository<CourseRegistrations> CourseRegistrations { get; }

        public IRepository<Lecturer> Lecturer { get; }

        public IRepository<Log> Log { get; }

        public UnitOfWork(ApplicationDbContext context, 
            IRepository<Student> student, 
            IRepository<Course> course,
            IRepository<Lecturer> lecturer,
            IRepository<Log> log,
            IRepository<CourseRegistrations> courseRegistrations)
        {
            _context = context;
            Student = student;
            Course = course;
            Lecturer =  lecturer;
            Log = log;
            CourseRegistrations = courseRegistrations;
        }

        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
