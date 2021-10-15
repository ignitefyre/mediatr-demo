using System.Threading;
using System.Threading.Tasks;
using Ignite.Mediatr.Events;
using Ignite.Mediatr.Queries;
using MediatR;

namespace Ignite.Mediatr.Handlers
{
    public class EmployeeCreatedEventHandler : INotificationHandler<EmployeeCreatedEvent>
    {
        private readonly IMediator mediator;

        public EmployeeCreatedEventHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task Handle(EmployeeCreatedEvent notification, CancellationToken cancellationToken)
        {
            await this.mediator.Send(new EmailNewEmployeeCommand());
        }
    }
}