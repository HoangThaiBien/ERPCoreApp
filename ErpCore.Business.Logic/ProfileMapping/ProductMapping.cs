﻿using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.ProfileMapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping() {
            CreateMap<ProductModel, Product>().ReverseMap();
        }
    }
}
