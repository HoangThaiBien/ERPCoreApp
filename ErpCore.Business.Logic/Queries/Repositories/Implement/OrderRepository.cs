using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class OrderRepository : IOrderRepository
    {
        public Task<OrderModel> Add(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> Update(int id, OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
