using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CartRepository : ICartRepository
    {
        public Task<int> Add(CartModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CartModel model)
        {
            throw new NotImplementedException();
        }
    }
}
