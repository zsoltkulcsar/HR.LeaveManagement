using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Queries.GetLeaveRequestDetail
{
    public class GetLeaveRequestDetailQuery : IRequest<LeaveRequestDetailsDto>
    {
        public int Id { get; set; }
    }
}
