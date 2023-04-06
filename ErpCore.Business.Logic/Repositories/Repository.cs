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

        public async Task Add(TDto entity)
        {
            var newItem = _mapper.Map<TEntity>(entity);
            await _entities.AddAsync(newItem);
            await _context.SaveChangesAsync();
        }

        public async Task AddRange(IEnumerable<TDto> entities)
        {
            var newListItem = _mapper.Map< IEnumerable<TEntity>>(entities);
            await _entities.AddRangeAsync(newListItem);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _entities.FindAsync(id);
            _entities.Remove(entity!);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(IEnumerable<int> ids)
        {
            foreach(var id in ids)
            {
                var entity = await _entities.FindAsync(id);
                _entities.RemoveRange(entity!);
            }    
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TDto>> GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _entities;

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            var entities = await query.ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await _entities.FindAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<IEnumerable<TDto>> FindItem(Expression<Func<TEntity, bool>> predicate)
        {
            var entityPredicate = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            var entities = await _entities.Where(entityPredicate).ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }
        public async Task Update(TDto entity)
        {
            var UpdateItem = _mapper.Map<TEntity>(entity);
            _entities.Update(UpdateItem);
            await _context.SaveChangesAsync();

        }
    }
}
