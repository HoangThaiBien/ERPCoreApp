using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
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
    }
}
