using Management.Comands.Interfaces;
using Management.Comands.StudentCommands;
using Management.Comands.StudentCommands.Models;
using Management.Comands.Utils;
using Management.Query.Interfaces;
using Management.Query.StudentQuery;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Controllers
{
    public class StudentController : BaseApiController
    {
        private readonly ICommandProccessor _commandProccessor;
        private readonly IQueryProccessor _queryProccessor;

        public StudentController(ICommandProccessor commandProccessor, IQueryProccessor queryProccessor)
        {
            _commandProccessor = commandProccessor;
            _queryProccessor = queryProccessor;
        }
        [HttpPost]
        public IActionResult AddStudent(StudentAddRequest request)
        {
            var studentAddCommand = new StudentAddCommand(request);
            _commandProccessor.Execute(studentAddCommand);

            return _commandProccessor.Result.Status != CommandResultStatus.Success ?
                BadRequest(_commandProccessor.Result.Message) : Ok(_commandProccessor.Result.Message);
        }

        [HttpPut]
        public IActionResult UpdateStudent(StudentUpdateRequest request)
        {
            var studentUpdateCommand = new StudentUpdateCommand(request);
            _commandProccessor.Execute(studentUpdateCommand);

            return _commandProccessor.Result.Status != CommandResultStatus.Success ?
                BadRequest(_commandProccessor.Result.Message) : Ok(_commandProccessor.Result.Message);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var stuentDeleteCommand = new StudentDeleteCommand(id);
            _commandProccessor.Execute(stuentDeleteCommand);

            return _commandProccessor.Result.Status != CommandResultStatus.Success ?
              BadRequest(_commandProccessor.Result.Message) : Ok(_commandProccessor.Result.Message);

        }

        [HttpGet]
        public IActionResult GetStudentList()
        {
            var studentListQuery = new StudentListQuery();
            var response = _queryProccessor.Execute(studentListQuery);
            return Ok(response);
        }
    }
}
