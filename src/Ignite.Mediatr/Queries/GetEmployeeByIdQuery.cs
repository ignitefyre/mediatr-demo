using Ignite.Mediatr.Models;
using MediatR;

namespace Ignite.Mediatr.Queries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}