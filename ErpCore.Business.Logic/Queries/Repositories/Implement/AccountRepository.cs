using AutoMapper;
using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Implement;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        public AccountRepository(ErpDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Add(AccountModel account)
        {
            var newAccount = _mapper.Map<Account>(account);
            newAccount.setCreateInfo(newAccount.Username!, DateTime.UtcNow);
            _context.Accounts.Add(newAccount);
            await _context.SaveChangesAsync();
            return newAccount.Id;
        }

        public async Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AccountModel>> GetAll()
        {
            var Accounts = await _context!.Accounts.ToListAsync();
            return _mapper!.Map<List<AccountModel>>(Accounts);
        }

        public async Task<AccountModel> GetById(int id)
        {
            var Accounts = await _context!.Accounts.FindAsync(id);
            return _mapper!.Map<AccountModel>(Accounts);
        }

        public async Task<AccountModel> GetByName(string name)
        {
            var Accounts = await _context!.Accounts.FirstOrDefaultAsync(x => x.Username == name);
            return _mapper!.Map<AccountModel>(Accounts);
        }

        public async Task Update(AccountModel account, int id)
        {
            throw new NotImplementedException();
        }
    }
}
