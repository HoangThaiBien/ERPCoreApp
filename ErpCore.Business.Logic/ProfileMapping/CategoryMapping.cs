﻿using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Helpers
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping() {
            CreateMap<CategoryModel, Category>().ReverseMap();
        }
    }
}
