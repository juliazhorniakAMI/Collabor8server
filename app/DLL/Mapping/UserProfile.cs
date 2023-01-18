using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.DTOs;
using app.ModelsDTO.User;
using AutoMapper;

namespace app.DLL.Mapping
{
     class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
             CreateMap<User, UserDashboardDTO>().ReverseMap();
        }
    }
}