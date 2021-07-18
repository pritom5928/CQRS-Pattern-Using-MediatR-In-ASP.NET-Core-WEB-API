using EmployeeManagementLibrary.Commands;
using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers.Commands
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeModel>
    {
        private readonly IDataAccess _dataAccess;

        public AddEmployeeHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var newEmployee = _dataAccess.AddEmployee(request.firstName, request.lastName);

            return Task.FromResult(newEmployee);
        }
    }
}
