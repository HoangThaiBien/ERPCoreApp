global using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Customer : BaseEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; } 
        public string? PostalCode { get; set; } 
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Location? Location { get; set; }
        public string? CoverImage { get; set; }
        public string? Avatar { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }
    }
}
