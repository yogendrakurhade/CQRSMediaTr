using CQRSMediaTr.Models;
using CQRSMediaTr.Services;
using MediatR;

namespace CQRSMediaTr.Data.Handler
{
    public class GetEmployeeHandler: IRequestHandler<GetEmployeeIdByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(GetEmployeeIdByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
