using Management.Comands.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Comands.Interfaces
{
    public interface ICommandProccessor
    {
        void Execute(CommandBase command);
        CommandResult Result { get; set; }
    }
}
