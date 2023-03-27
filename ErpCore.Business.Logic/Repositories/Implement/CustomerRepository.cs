using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<int> Add(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
