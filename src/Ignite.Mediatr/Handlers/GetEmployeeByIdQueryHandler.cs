using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ignite.Mediatr.Models;
using Ignite.Mediatr.Queries;
using MediatR;

namespace Ignite.Mediatr.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IMediator mediator;

        public GetEmployeeByIdQueryHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employees = await this.mediator.Send(new GetEmployeeListQuery());

            return employees.FirstOrDefault(x => x.Id == request.Id);
        }
    }
}