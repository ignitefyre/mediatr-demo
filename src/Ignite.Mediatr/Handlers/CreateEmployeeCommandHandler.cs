using System.Threading;
using System.Threading.Tasks;
using Ignite.Mediatr.Events;
using Ignite.Mediatr.Queries;
using MediatR;

namespace Ignite.Mediatr.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IMediator mediator;

        public CreateEmployeeCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var result = 5;

            await this.mediator.Publish(new EmployeeCreatedEvent(result));

            return result;
        }
    }
}