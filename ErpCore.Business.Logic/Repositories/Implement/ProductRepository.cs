using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class ProductRepository : IProductRepository
    {
        public Task<int> Add(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
