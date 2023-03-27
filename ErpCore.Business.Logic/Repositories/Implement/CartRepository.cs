using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Database.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class CartRepository : ICartRepository
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        public CartRepository(ErpDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<int> Add(CartModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CartModel model)
        {
            throw new NotImplementedException();
        }
    }
}
