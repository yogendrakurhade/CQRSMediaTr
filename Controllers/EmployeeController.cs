using CQRSMediaTr.Data;
using CQRSMediaTr.Data.Command;
using CQRSMediaTr.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediaTr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get: api/<EmployeeController>
        [HttpGet]
        public async Task<List<Employee>> EmployeeList()
        {
            var employeeList = await _mediator.Send(new GetEmployeeListQuery());
            return employeeList;
        }

        //Get: api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> EmployeeById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeIdByIdQuery() { Id = id });
            return employee;
        }

        //Post: api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var employeeReturn = await _mediator.Send(new CreateEmployeeCommand(employee.Name, employee.Address, employee.Phone, employee.Phone));
            return employeeReturn;
        }

        //Put: api/<EmployeeController>/5
        [HttpPut]
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeReturn = await _mediator.Send(new UpdteEmployeeCommand(employee.Id, employee.Name, employee.Address, employee.Email, employee.Phone));
            return employeeReturn;
        }

        //Delete: api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id = id });
        }
    }
}
