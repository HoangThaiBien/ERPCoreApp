using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> Add(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
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

        public Task Update(int id, OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
