using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.Models;
using ASS_API.DbModels;

namespace ASS_API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<AppointmentScheduling, AppointmentSchedulingModel>().ReverseMap();
            CreateMap<Court, CourtModel>().ReverseMap();
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Staff, StaffModel>().ReverseMap();
        }
    }
}
