using ErpCore.Business.Logic.Dtos;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface ICustomerRepository :IRepository<Customer ,CustomerModel>
    {
       /* public Task<List<CustomerModel>> GetAll();
        public Task<CustomerModel> GetById(int id);
        public Task<List<CustomerModel>> GetByName(string name);
        public Task<int> Add(CustomerModel model);
        public Task Update(int id, CustomerModel model);
        public Task DeleteById(int id);*/
    }
}
