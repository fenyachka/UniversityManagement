using Management.Comands.Interfaces;
using Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Management.Comands.StudentCommands
{
    public class StudentDeleteCommand : CommandBase
    {
        private readonly int _id;

        public StudentDeleteCommand(int id)
        {
           _id = id;
        }

        public override void Action()
        {
            var student = UnitOfWork.Student.TableNoTracking.SingleOrDefault(x => x.Id == _id);
            UnitOfWork.Student.Delete(student);
            var log = new Log()
            {
                ActionType = "studentis washla",
                Data = JsonSerializer.Serialize(student),
                ActionDate = DateTime.Now
            };
            UnitOfWork.Log.Add(log);
            UnitOfWork.Complete();
        }
    }
}
