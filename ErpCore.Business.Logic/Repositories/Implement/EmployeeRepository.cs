using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<int> Add(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
