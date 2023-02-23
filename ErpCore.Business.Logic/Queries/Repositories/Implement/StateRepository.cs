using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class StateRepository : IStateRepository
    {
        public Task<StateModel> Add(StateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<StateModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StateModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StateModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StateModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<StateModel> Update(int id, StateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
