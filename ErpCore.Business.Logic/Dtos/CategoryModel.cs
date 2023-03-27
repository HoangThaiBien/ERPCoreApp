using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Entities;
using ErpCore.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class CategoryModel
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public virtual ICollection<ProductCategoryModel>? ProductCategories { get; set; }
    }
}
