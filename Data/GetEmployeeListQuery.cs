using CQRSMediaTr.Models;
using MediatR;

namespace CQRSMediaTr.Data
{
    public class GetEmployeeListQuery: IRequest<List<Employee>>
    {
    }
}
