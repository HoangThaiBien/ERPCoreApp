using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class SlideModel : BaseEntity
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Description { set; get; }
        public string? Url { set; get; }
        public string? Image { get; set; }
        public int SortOrder { get; set; }
        public Status Status { set; get; }
    }
}
