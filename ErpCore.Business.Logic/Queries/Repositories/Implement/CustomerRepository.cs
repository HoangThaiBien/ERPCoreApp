using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<CustomerModel> Add(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> DeleteById(int id)
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

        public Task<CustomerModel> Update(int id, CustomerModel model)
        {
            throw new NotImplementedException();
        }
    }
}
