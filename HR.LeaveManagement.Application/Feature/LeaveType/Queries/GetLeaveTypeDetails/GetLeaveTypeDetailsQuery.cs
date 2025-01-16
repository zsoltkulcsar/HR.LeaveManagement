using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetLeaveTypeDetails
{
    public record GetLeaveTypeDetailsQuery : IRequest<List<LeaveTypeDetailsDto>>;
}
