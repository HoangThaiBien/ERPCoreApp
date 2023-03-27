using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface ILocationRepository
    {
        public Task<List<LocationModel>> GetAll();
        public Task<LocationModel> GetById(int id);
        public Task<List<LocationModel>> GetByName(string name);
        public Task<int> Add(LocationModel model);
        public Task Update(int id, LocationModel model);
        public Task DeleteById(int id);
    }
}
