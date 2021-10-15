using System;
using System.Threading;
using System.Threading.Tasks;
using Ignite.Mediatr.Queries;
using MediatR;

namespace Ignite.Mediatr.Handlers
{
    public class EmailNewEmployeeCommandHandler : IRequestHandler<EmailNewEmployeeCommand>
    {
        public async Task<Unit> Handle(EmailNewEmployeeCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Email employee");

            return Unit.Value;
        }
    }
}