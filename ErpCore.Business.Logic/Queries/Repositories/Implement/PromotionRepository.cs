using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class PromotionRepository : IPromotionRepository
    {
        public Task<PromotionModel> Add(PromotionModel model)
        {
            throw new NotImplementedException();
        }

        public Task<PromotionModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PromotionModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PromotionModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PromotionModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<PromotionModel> Update(int id, PromotionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
