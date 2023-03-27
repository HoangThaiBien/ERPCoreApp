using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public Task<int> Add(OrderDetailModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, OrderDetailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
