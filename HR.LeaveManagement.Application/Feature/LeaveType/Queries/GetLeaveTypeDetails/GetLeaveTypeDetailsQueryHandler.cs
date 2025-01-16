using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetLeaveTypeDetails
{
    public sealed class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, List<LeaveTypeDetailsDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<List<LeaveTypeDetailsDto>> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveTypeDetails = await _leaveTypeRepository.GetAsync();

            var leaveTypeDetailsDto = _mapper.Map<List<LeaveTypeDetailsDto>>(leaveTypeDetails);

            return leaveTypeDetailsDto;
        }
    }
}
