using AutoMapper;
using BlackFridaySniffer.Models;
using ProductLoader.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLoader.Profiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<CreateProductDto, Product>();
        }
    }
}
