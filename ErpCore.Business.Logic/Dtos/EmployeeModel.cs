using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class EmployeeModel : BaseEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? CoverImage { get; set; }
        public string? Avatar { get; set; }
        public IFormFile? AvatarFilePath { get; set; }
        public IFormFile? CoverImageFilePath { get; set;}
    }
}
