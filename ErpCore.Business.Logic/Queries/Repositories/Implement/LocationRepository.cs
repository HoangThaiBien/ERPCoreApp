using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class LocationRepository : ILocationRepository
    {
        public Task<LocationModel> Add(LocationModel model)
        {
            throw new NotImplementedException();
        }

        public Task<LocationModel> DeleteById(int id)
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

        public Task<LocationModel> Update(int id, LocationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
