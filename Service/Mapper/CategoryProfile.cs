﻿using AutoMapper;
using DataAccessLayer.ModelsDTO;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapper
{
    public class CategoryProfile: Profile
    {
        public void CreateMap(IMapperConfigurationExpression cfg) {

            cfg.CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }
}
