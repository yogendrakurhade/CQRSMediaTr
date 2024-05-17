using MediatR;

namespace CQRSMediaTr.Data.Command
{
    public class DeleteEmployeeCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}
