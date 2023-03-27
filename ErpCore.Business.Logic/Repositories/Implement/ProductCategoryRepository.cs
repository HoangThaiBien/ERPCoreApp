using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public Task<int> Add(ProductCategoryModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
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

        public Task Update(int id, ProductCategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
