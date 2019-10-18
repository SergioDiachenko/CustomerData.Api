using AutoMapper;
using CustomerData.Api.Data.Entities;
using CustomerData.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Data
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Customer, CustomerModel>()
                .ReverseMap();
        } 
    }
}