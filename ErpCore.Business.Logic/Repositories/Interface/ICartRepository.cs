using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface ICartRepository
    {
        public Task<List<CartModel>> GetAll();
        public Task<CartModel> GetById(int id);
        public Task<List<CartModel>> GetByName(string name);
        public Task<int> Add(CartModel model);
        public Task Update(int id, CartModel model);
        public Task DeleteById(int id);
    }
}
