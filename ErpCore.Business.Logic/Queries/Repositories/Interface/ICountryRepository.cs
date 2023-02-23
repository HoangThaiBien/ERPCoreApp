using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ICountryRepository
    {
        public Task<List<CountryModel>> GetAll();
        public Task<CountryModel> GetById(int id);
        public Task<List<CountryModel>> GetByName(string name);
        public Task<int> Add(CountryModel model);
        public Task Update(int id, CountryModel model);
        public Task DeleteById(int id);
    }
}
