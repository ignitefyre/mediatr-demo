using MediatR;

namespace Ignite.Mediatr.Queries
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}