using AutoMapper;
using HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Mapping_Profiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>();
        }
    }
}
