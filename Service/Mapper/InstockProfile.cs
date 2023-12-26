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
    public class InstockProfile: Profile
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<InstockDTO, InstockEntity>().ReverseMap();
        }
    }
}
