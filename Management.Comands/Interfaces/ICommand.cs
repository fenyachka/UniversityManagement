using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Comands.Interfaces
{
    public interface ICommand
    {
        IUnitOfWork UnitOfWork { get; }
        void Action();

    }

    public abstract class CommandBase : ICommand
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public abstract void Action();
    }
}
