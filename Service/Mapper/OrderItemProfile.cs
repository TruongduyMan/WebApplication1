using AutoMapper;
using DataAccessLayer.ModelsEntity;
using Service.ModelsDTO;
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
            cfg.CreateMap<OrderItemDTO, OrderItemEntity>().ReverseMap();
        }
    }
}
