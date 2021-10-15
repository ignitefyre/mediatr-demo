using System.Threading.Tasks;
using Ignite.Mediatr.Models;
using Ignite.Mediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ignite.Mediatr.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("/employees")]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await this.mediator.Send(new GetEmployeeListQuery());

            return Ok(result);
        }

        [HttpGet]
        [Route("/employees/{id}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] int id)
        {
            var result = await this.mediator.Send(new GetEmployeeByIdQuery { Id = id });

            return Ok(result);
        }

        [HttpPost]
        [Route("/employees")]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeRequest request)
        {
            var result = await this.mediator.Send(
                new CreateEmployeeCommand { FirstName = request.FirstName, LastName = request.LastName });

            return Ok(result);
        }
    }
}