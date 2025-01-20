using FluentValidation;

namespace HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.ChangeLeaveRequestApproval
{
    public class ChangeLeaveRequestApprovalCommandValidator : AbstractValidator<ChangeLeaveRequestApprovalCommand>
    {
        public ChangeLeaveRequestApprovalCommandValidator()
        {
            RuleFor(p => p.Approved)
                .NotNull()
                .WithMessage("Approval status cannot be null");
        }
    }
}
