using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public Task<ProductCategoryModel> Add(ProductCategoryModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategoryModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductCategoryModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategoryModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductCategoryModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategoryModel> Update(int id, ProductCategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
