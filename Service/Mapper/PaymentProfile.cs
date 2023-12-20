﻿using AutoMapper;
using DataAccessLayer.ModelsEntity;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapper
{
    public class PaymentProfile: Profile
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Payment, PaymentEntity>().ReverseMap();
        }
    }
}