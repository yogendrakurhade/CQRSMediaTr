using CQRSMediaTr.Data.Command;
using CQRSMediaTr.Models;
using CQRSMediaTr.Services;
using MediatR;

namespace CQRSMediaTr.Data.Handler
{
    public class UpdateEmployeeHandler: IRequestHandler<UpdteEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(UpdteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            employee.Name = request.Name;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.Address = request.Address;
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
