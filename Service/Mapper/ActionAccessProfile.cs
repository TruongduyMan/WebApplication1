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
    public class ActionAccessProfile: Profile
    {
        public ActionAccessProfile() { 
            CreateMap<ActionAccess, ActionAccessDTO>().ReverseMap();
        }
    }
}
