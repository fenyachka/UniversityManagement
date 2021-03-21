using Management.Comands.Interfaces;
using Management.Comands.StudentCommands.Models;
using Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Management.Comands.StudentCommands
{
    public class StudentAddCommand : CommandBase
    {
        private readonly StudentAddRequest _request;

        public StudentAddCommand(StudentAddRequest request)
        {
            _request = request;
        }

        public override void Action()
        {
            var checkExists = UnitOfWork.Student.TableNoTracking.Any(x => x.PrivateNumber == _request.PrivateNumber);
            if (checkExists)
            {
                throw new ApplicationException("student already exists");
            }
            var newStudent = new Student()
            {
                PrivateNumber = _request.PrivateNumber,
                Firstname = _request.Firstname,
                Lastname = _request.Lastname,
                Address = _request.Address,
                RegistrationDate = DateTime.Now
            };

            UnitOfWork.Student.Add(newStudent);

            var log = new Log()
            {
                ActionType = "studentis damateba",
                Data = JsonSerializer.Serialize(newStudent),
                ActionDate = DateTime.Now
            };
            UnitOfWork.Log.Add(log);

            UnitOfWork.Complete();
        }
    }
}
