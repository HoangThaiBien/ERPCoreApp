using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public partial class EmployeeRepository : Repository<Employee,EmployeeModel>, IEmployeeRepository
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        public EmployeeRepository(ErpDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeModel> GetByIdWithRoleAndLocation(int id)
        {
            var entity = await _context.Set<Employee>()
                                       .Include(e => e.EmployeeRole)
                                       .Include(e => e.Location)
                                       .FirstOrDefaultAsync(e => e.Id == id);

            return _mapper.Map<EmployeeModel>(entity);
        }
       

        /*public async Task<EmployeeModel> UpdateWithImage(EmployeeModel model)
        {
            var entity = await _context.Employees.FindAsync(model.Id);
            if (entity != null)
            {
                entity = _mapper.Map<Employee>(model); ;
                entity!.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Description = model.Description;
                entity.Address = model.Address;
                entity.PhoneNumber = model.PhoneNumber;
                entity.Email = model.Email;
                entity.AcademicLevel = model.AcademicLevel;
                entity.WorkExperience = model.WorkExperience;
                entity.Department = model.Department;
                entity.Role = model.Role;
                entity.DateOfBirth = model.DateOfBirth;
                entity.LastUpdateBy = model.LastUpdateBy;
                entity.LastUpdateAt = model.LastUpdateAt;
                entity.Avatar = model.Avatar;
                entity.CoverImage = model.CoverImage;
                await _context.SaveChangesAsync();
                return _mapper.Map<EmployeeModel>(entity);
            }
            return null;
        }
    */
    }
}
