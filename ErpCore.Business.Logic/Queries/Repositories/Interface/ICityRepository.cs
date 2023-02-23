using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ICityRepository
    {
        public Task<List<CityModel>> GetAll();
        public Task<CityModel> GetById(int id);
        public Task<List<CityModel>> GetByName(string name);
        public Task<int> Add(CityModel model);
        public Task Update(int id, CityModel model);
        public Task DeleteById(int id);
    }
}
