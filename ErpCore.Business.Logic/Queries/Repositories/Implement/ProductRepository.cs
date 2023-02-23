using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class ProductRepository : IProductRepository
    {
        public Task<ProductModel> Add(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> DeleteById(int id)
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

        public Task<ProductModel> Update(int id, ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
