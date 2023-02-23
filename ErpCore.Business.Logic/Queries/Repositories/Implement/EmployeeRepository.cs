using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<EmployeeModel> Add(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> DeleteById(int id)
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

        public Task<EmployeeModel> Update(int id, EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
