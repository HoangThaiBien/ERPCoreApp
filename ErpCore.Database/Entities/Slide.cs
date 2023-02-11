using ErpCore.Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Slide : BaseEntity
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
