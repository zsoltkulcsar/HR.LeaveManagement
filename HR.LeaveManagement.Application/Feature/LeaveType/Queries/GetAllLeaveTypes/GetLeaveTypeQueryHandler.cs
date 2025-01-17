using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetAllLeaveTypes
{
    public sealed class GetLeaveTypeQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IAppLogger<GetLeaveTypeQueryHandler> _logger;

        public GetLeaveTypeQueryHandler(
            IMapper mapper, 
            ILeaveTypeRepository leaveTypeRepository,
            IAppLogger<GetLeaveTypeQueryHandler> logger)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
            _logger = logger;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {

            var leaves = await _leaveTypeRepository.GetAsync();

            var leavesDto = _mapper.Map<List<LeaveTypeDto>>(leaves);

            _logger.LogInformation("Leave types were retrieved succesfully");
            return leavesDto;
        }

    }
}
