using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public Task<OrderDetailModel> Add(OrderDetailModel model)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailModel> DeleteById(int id)
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

        public Task<OrderDetailModel> Update(int id, OrderDetailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
