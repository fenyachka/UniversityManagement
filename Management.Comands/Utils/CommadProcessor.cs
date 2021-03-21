using Management.Comands.Interfaces;
using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Comands.Utils
{
    public class CommadProcessor : ICommandProccessor
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommandResult Result { get; set; }
        public CommadProcessor(IUnitOfWork unitOfWork)
        {
            Result = new CommandResult();
            _unitOfWork = unitOfWork;
        }


        public void Execute(CommandBase command)
        {
            try
            {
                command.UnitOfWork = _unitOfWork;
                command.Action();

                this.Result.Status = CommandResultStatus.Success;
                this.Result.Message = "operacia warmaten=biT Sesrulda";

            }
            catch (Exception ex)
            {

                this.Result.Status = CommandResultStatus.Error;
                this.Result.Message = ex.Message;
            }
        }
    }
}
