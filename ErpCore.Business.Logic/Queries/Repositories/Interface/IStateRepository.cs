using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IStateRepository
    {
        public Task<List<StateModel>> GetAll();
        public Task<StateModel> GetById(int id);
        public Task<List<StateModel>> GetByName(string name);
        public Task<int> Add(StateModel model);
        public Task Update(int id, StateModel model);
        public Task DeleteById(int id);
    }
}
