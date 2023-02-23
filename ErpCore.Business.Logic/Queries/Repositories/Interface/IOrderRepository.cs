using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IOrderRepository
    {
        public Task<List<OrderModel>> GetAll();
        public Task<OrderModel> GetById(int id);
        public Task<List<OrderModel>> GetByName(string name);
        public Task<int> Add(OrderModel model);
        public Task Update(int id, OrderModel model);
        public Task DeleteById(int id);
    }
}
