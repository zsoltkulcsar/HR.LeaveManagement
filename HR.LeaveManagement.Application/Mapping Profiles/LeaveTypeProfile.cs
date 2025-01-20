using AutoMapper;
using HR.LeaveManagement.Application.Feature.LeaveType.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Feature.LeaveType.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>();
            CreateMap<CreateLeaveTypeCommand, LeaveType>();
            CreateMap<UpdateLeaveTypeCommand, LeaveType>();
        }
    }
}
