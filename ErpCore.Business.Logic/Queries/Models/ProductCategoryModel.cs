﻿using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class ProductCategoryModel : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual ProductModel? Product { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryModel? Category { get; set; }
   
    }
}
