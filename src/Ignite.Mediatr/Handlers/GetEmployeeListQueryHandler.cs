using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ignite.Mediatr.DataAccess;
using Ignite.Mediatr.Models;
using Ignite.Mediatr.Queries;
using MediatR;

namespace Ignite.Mediatr.Handlers
{
    public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IDataAccess dataAccess;

        public GetEmployeeListQueryHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await this.dataAccess.GetEmployees();
        }
    }
}