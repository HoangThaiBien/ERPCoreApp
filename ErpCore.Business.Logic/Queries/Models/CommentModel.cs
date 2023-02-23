using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class CommentModel : BaseEntity
    {
        public int Id { get; set; }
        public string? Content { get; set; }
    }
}
