using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CityRepository : ICityRepository
    {
        public Task<CityModel> Add(CityModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CityModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CityModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CityModel> Update(int id, CityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
