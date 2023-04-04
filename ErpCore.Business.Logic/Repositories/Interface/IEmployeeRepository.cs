using ErpCore.Business.Logic.Dtos;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IEmployeeRepository : IRepository<Employee,EmployeeModel>
    {
        /*public Task<List<EmployeeModel>> GetAll();
        public Task<EmployeeModel> GetById(int id);
        public Task<List<EmployeeModel>> GetByName(string name);
        public Task<int> Add(EmployeeModel model);
        public Task AddRange(IEnumerable<EmployeeModel> entities);
        public Task Update(int id, EmployeeModel model);
        public Task Delete(int id);
        public Task DeleteRange(IEnumerable<int> id);*/
        Task<EmployeeModel> GetByIdWithRoleAndLocation(int id);
    }
}
