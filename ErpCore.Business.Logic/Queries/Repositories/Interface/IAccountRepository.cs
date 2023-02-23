using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IAccountRepository
    {
        public Task<List<AccountModel>> GetAll();
        public Task<AccountModel> GetById(int id);
        public Task<AccountModel> GetByName(string name);
        public Task<int> Add(AccountModel account);
        public Task Update(AccountModel account, int id);
        public Task DeleteById(int id);
    }
}
