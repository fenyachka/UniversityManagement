using Management.Domain.Interfaces;
using Management.Query.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Query.Utils
{
    public class QueryProccessor : IQueryProccessor

    {
        private readonly IUnitOfWork _unitOfWork;

        public QueryProccessor(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T Execute<T>(QueryBase<T> query)
        {
            query.UnitOfWork = _unitOfWork;
            return query.Action();
        }
    }
}
