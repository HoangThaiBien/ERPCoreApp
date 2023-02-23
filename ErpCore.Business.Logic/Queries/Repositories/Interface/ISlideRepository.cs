using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ISlideRepository
    {
        public Task<List<SlideModel>> GetAll();
        public Task<SlideModel> GetById(int id);
        public Task<List<SlideModel>> GetByName(string name);
        public Task<int> Add(SlideModel model);
        public Task Update(int id, SlideModel model);
        public Task DeleteById(int id);
    }
}
