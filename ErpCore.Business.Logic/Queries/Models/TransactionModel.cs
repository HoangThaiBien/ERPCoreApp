using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class TransactionModel : BaseEntity
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string? ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string? Result { set; get; }
        public string? Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string? Provider { set; get; }
        public int CustomerId { get; set; }
        public virtual CustomerModel? Customer { get; set; }
    }
}
