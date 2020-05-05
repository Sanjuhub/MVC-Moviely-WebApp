﻿using AutoMapper;
using Codely.Dtos;
using Codely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codely.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}