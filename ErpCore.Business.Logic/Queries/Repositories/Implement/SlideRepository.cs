using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class SlideRepository : ISlideRepository
    {
        public Task<SlideModel> Add(SlideModel model)
        {
            throw new NotImplementedException();
        }

        public Task<SlideModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SlideModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SlideModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SlideModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<SlideModel> Update(int id, SlideModel model)
        {
            throw new NotImplementedException();
        }
    }
}
