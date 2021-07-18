using EmployeeManagementLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Commands
{
    public record AddEmployeeCommand(string firstName, string lastName) : IRequest<EmployeeModel>;
}
