using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetAllLeaveTypes
{
    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
    
}
