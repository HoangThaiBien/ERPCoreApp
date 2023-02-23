using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Account : BaseEntity
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        // Khóa ngoại tham chiếu đến bảng Customer
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

    }
}
