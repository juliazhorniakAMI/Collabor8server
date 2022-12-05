using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using AutoMapper;

namespace app.DLL.Mapping
{
     class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
        }
    }
}