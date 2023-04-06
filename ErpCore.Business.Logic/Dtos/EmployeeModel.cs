using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Entities;
using ErpCore.Database.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        public Gender Gender { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? AcademicLevel { get; set; }
        public string? WorkExperience { get; set; }
        public Departments Department { get; set; }
        public Roles Role { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string? CoverImage { get; set; }
        public string? Avatar { get; set; }
        public IFormFile? AvatarFilePath { get; set; }
        public IFormFile? CoverImageFilePath { get; set; }

    }   
}
