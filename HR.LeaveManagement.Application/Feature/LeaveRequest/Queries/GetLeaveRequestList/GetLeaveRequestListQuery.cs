using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Queries.GetLeaveRequestList
{
    public class GetLeaveRequestListQuery : IRequest<List<LeaveRequestListDto>>
    {
        public bool IsLoggedInUser { get; set; }
    }
}
