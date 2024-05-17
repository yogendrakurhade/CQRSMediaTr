using CQRSMediaTr.Models;
using MediatR;

namespace CQRSMediaTr.Data
{
    public class GetEmployeeIdByIdQuery: IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
