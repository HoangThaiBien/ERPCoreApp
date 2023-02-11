using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Common.Shared.Model
{
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set;}
        public string? LastUpdateBy{ get; set;}
        public DateTime? LastUpdateAt { get; set; }
        public bool? IsDeleted { get; set; }
        public BaseEntity SetCreateInfo(string user, DateTime date) 
        {
            this.CreatedBy = user;
            this.CreatedAt = date;
            return this;
        }

        public BaseEntity SetUpdateInfo(string user, DateTime date)
        {
            this.LastUpdateAt= date;
            this.LastUpdateBy = user;
            return this;
        }
    }
}
