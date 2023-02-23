using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CountryRepository : ICountryRepository
    {
        public Task<CountryModel> Add(CountryModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel> Update(int id, CountryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
