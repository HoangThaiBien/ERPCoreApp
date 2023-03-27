using AutoMapper;
using AutoMapper.QueryableExtensions;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories
{
    public class Repository<TEntity, TDto> : IRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        private DbSet<TEntity> _entities;
        public Repository(ErpDbContext repo, IMapper mapper)
        {

            _context = repo;
            _mapper = mapper;
            _entities = _context.Set<TEntity>();
        }

        public async Task AddItem(TDto entity)
        {
            var newItem = _mapper.Map<TEntity>(entity);
            await _entities.AddAsync(newItem);
            await _context.SaveChangesAsync();
        }

        public async Task AddRange(IEnumerable<TDto> entities)
        {
            var newListItem = _mapper.Map<TEntity>(entities);
            await _entities.AddRangeAsync(newListItem);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _entities.FindAsync(id);
            _entities.Remove(entity!);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(IEnumerable<int> id)
        {
            var entity = await _entities.FindAsync(id);
            _entities.RemoveRange(entity!);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TDto>> GetAll()
        {
            var ListItem = await _entities.ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(ListItem);
        }

        public async Task<TDto> GetById(int id)
        {
            var ListItem = await _entities.FindAsync(id);
            return _mapper.Map<TDto>(ListItem);
        }

        public async Task<IEnumerable<TDto>> FindItem(Expression<Func<TEntity, bool>> predicate)
        {
            var entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            var entities = await _entities.Where(entityPredicate).ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }
        public async Task Update(TDto entity)
        {
            var UpdateTag = _mapper.Map<TEntity>(entity);
            _entities.Update(UpdateTag);
            await _context.SaveChangesAsync();

        }
    }
}
