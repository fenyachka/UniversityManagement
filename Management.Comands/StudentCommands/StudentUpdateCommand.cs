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
    public class StudentUpdateCommand : CommandBase
    {
        private readonly StudentUpdateRequest _request;

        public StudentUpdateCommand(StudentUpdateRequest request)
        {
            _request = request;
        }

        public override void Action()
        {
            var student = UnitOfWork.Student.TableNoTracking.SingleOrDefault(x => x.Id == _request.Id);


            student.Firstname = _request.Firstname;
            student.Lastname = _request.Lastname;
            student.PrivateNumber = _request.PrivateNumber;
            student.Address = _request.Address;

            UnitOfWork.Student.Update(student);
            var log = new Log()
            {
                ActionType = "studentis ganaxleba",
                Data = JsonSerializer.Serialize(student),
                ActionDate = DateTime.Now
            };
            UnitOfWork.Log.Add(log);
            UnitOfWork.Complete();

        }
    }
}
