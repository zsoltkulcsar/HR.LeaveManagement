using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Feature.LeaveRequest.Shared;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommandValidator : AbstractValidator<CreateLeaveRequestCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestCommandValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new BaseLeaveRequestValidator(_leaveTypeRepository));
        }
    }
}
