using CQRSMediaTr.Models;

namespace CQRSMediaTr.Services
{
    public interface IEmployeeRepository
    {
        //query operations
        public Task<List<Employee>> GetEmployeeListAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
        //command operations
        public Task<Employee> AddEmployeeAsync(Employee employee);
        public Task<Employee> UpdateEmployeeAsync(Employee employee);
        public Task<int> DeleteEmployeeAsync(int employeeId);
    }
}
