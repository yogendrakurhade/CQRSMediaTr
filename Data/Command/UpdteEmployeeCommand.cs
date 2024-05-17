using CQRSMediaTr.Models;
using MediatR;

namespace CQRSMediaTr.Data.Command
{
    public class UpdteEmployeeCommand: IRequest<Employee>
    {
        public UpdteEmployeeCommand(int id, string name, string address, string email, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
