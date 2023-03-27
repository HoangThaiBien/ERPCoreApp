using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IPromotionRepository
    {
        public Task<List<PromotionModel>> GetAll();
        public Task<PromotionModel> GetById(int id);
        public Task<List<PromotionModel>> GetByName(string name);
        public Task<int> Add(PromotionModel model);
        public Task Update(int id, PromotionModel model);
        public Task DeleteById(int id);
    }
}
