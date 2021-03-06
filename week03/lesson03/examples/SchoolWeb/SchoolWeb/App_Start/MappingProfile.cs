﻿using AutoMapper;
using SchoolWeb.Models;
using SchoolWeb.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWeb.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CourseDTO, Course>();
        }
    }
}