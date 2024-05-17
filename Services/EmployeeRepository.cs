using CQRSMediaTr.Data;
using CQRSMediaTr.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediaTr.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
    }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result = _dataContext.Employees.Add(employee);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int employeeId)
        {
            var filteredData = _dataContext.Employees.Where(x => x.Id == employeeId).FirstOrDefault();
            _dataContext.Employees.Remove(filteredData);
            return await _dataContext.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var filteredData = _dataContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            return filteredData;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var result = await _dataContext.Employees.ToListAsync();
            return result;
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            var employeeReturn = _dataContext.Employees.Update(employee);
            await _dataContext.SaveChangesAsync();
            return employeeReturn.Entity;
        }
    }
}
