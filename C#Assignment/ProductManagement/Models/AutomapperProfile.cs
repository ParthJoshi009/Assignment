using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProductManagement.Models;

namespace ProductManagement.Models
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<tblProduct, ProductClass>();
        }
    }
}