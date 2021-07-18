using EmployeeManagementLibrary.Commands;
using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<EmployeeModel>> GetAll()
        {
            var query = new GetEmployeeListQuery();
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<EmployeeModel> Get(int id)
        {
            var query = new GetEmployeeByIdQuery(id);
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<EmployeeModel> Create(string firstname, string lastname)
        {
            var query = new AddEmployeeCommand(firstname, lastname);
            return await _mediator.Send(query);
        }
    }
}
