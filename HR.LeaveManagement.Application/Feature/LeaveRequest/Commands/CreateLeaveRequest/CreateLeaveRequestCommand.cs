using HR.LeaveManagement.Application.Feature.LeaveRequest.Shared;
using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommand : BaseLeaveRequest, IRequest<Unit>
    {
        public string RequestComments { get; set; } = string.Empty;
    }
}
