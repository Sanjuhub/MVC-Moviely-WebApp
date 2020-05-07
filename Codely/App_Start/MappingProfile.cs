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
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}