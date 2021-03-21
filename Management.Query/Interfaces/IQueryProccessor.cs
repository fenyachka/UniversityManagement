using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Query.Interfaces
{
   public interface IQueryProccessor
    {
        T Execute<T>(QueryBase<T> query);
    }
}
