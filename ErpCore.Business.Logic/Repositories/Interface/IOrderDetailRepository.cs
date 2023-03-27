using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IOrderDetailRepository
    {
        public Task<List<OrderDetailModel>> GetAll();
        public Task<OrderDetailModel> GetById(int id);
        public Task<List<OrderDetailModel>> GetByName(string name);
        public Task<int> Add(OrderDetailModel model);
        public Task Update(int id, OrderDetailModel model);
        public Task DeleteById(int id);
    }
}
