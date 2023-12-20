using AutoMapper;
using DataAccessLayer.ModelsDTO;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapper
{
    public class OrderItemProfile: Profile
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
        }
    }
}
