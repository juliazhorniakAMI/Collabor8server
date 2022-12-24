using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using AutoMapper;

namespace app.DLL.Mapping
{
    public class PostOtherFounders:Profile
    {     
           public PostOtherFounders()
        {
              CreateMap<PostOtherFoundersDTO,Founder>().ReverseMap();                  
        }
    }
}