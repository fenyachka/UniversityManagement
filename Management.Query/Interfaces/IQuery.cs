using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Query.Interfaces
{
    public interface IQuery<T>
    {
        IUnitOfWork UnitOfWork { get; }

        T Action();
       
    }
    public abstract class QueryBase<T> : IQuery<T>
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public abstract T Action();
    }
}
