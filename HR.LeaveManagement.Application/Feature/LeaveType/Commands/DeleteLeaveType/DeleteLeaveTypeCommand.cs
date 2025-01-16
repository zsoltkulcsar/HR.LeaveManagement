using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveType.Commands.DeleteLeaveType
{
    public class DeleteLeaveTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
