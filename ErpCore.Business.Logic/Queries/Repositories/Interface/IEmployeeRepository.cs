using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IEmployeeRepository
    {
        public Task<List<EmployeeModel>> GetAll();
        public Task<EmployeeModel> GetById(int id);
        public Task<List<EmployeeModel>> GetByName(string name);
        public Task<int> Add(EmployeeModel model);
        public Task Update(int id, EmployeeModel model);
        public Task DeleteById(int id);
    }
}
