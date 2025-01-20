﻿using AutoMapper;
using HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.CreateLeaveRequest;
using HR.LeaveManagement.Application.Feature.LeaveRequest.Commands.UpdateLeaveRequest;
using HR.LeaveManagement.Application.Feature.LeaveRequest.Queries.GetLeaveRequestDetail;
using HR.LeaveManagement.Application.Feature.LeaveRequest.Queries.GetLeaveRequestList;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveRequestProfile : Profile
    {
        public LeaveRequestProfile()
        {
            CreateMap<LeaveRequestListDto, LeaveRequest>().ReverseMap();
            CreateMap<LeaveRequestDetailsDto, LeaveRequest>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDetailsDto>();
            CreateMap<CreateLeaveRequestCommand, LeaveRequest>();
            CreateMap<UpdateLeaveRequestCommand, LeaveRequest>();
        }
    }
}
