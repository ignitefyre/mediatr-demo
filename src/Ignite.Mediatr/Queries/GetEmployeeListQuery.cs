using System.Collections.Generic;
using Ignite.Mediatr.Models;
using MediatR;

namespace Ignite.Mediatr.Queries
{
    public class GetEmployeeListQuery : IRequest<List<Employee>> { }
}