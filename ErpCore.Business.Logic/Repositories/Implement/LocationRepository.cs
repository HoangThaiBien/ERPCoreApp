using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class LocationRepository : ILocationRepository
    {
        public Task<int> Add(LocationModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LocationModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LocationModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LocationModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, LocationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
