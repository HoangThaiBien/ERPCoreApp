using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class PromotionRepository : IPromotionRepository
    {
        public Task<int> Add(PromotionModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
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

        public Task Update(int id, PromotionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
