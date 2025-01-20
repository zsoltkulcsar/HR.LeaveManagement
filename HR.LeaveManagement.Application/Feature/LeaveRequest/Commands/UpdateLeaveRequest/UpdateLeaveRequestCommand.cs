using HR.LeaveManagement.Application.Feature.LeaveRequest.Shared;
using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.UpdateLeaveRequest
{
    public class UpdateLeaveRequestCommand : BaseLeaveRequest, IRequest<Unit>
    {
        public int Id { get; set; }
        public string RequestComments { get; set; } = string.Empty;
        public bool Cancelled { get; set; }
    }
}
