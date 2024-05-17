using CQRSMediaTr.Data.Command;
using CQRSMediaTr.Models;
using CQRSMediaTr.Services;
using MediatR;

namespace CQRSMediaTr.Data.Handler
{
    public class CreateEmployeeHandler: IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = new Employee
            {
                Address = request.Address,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone
            };
            return await _employeeRepository.AddEmployeeAsync(employee);
        }
    }
}
