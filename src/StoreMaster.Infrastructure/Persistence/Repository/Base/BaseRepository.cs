using Microsoft.EntityFrameworkCore;
using StoreMaster.Domain.Interface.Repository.Base;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Linq.Expressions;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public abstract class BaseRepository<TEntry, TInputIdentifier>(AppDbContext context) : IBaseRepository<TEntry, TInputIdentifier>
        where TEntry : BaseEntry<TEntry>, new()
    {
        protected readonly AppDbContext _context = context;
        protected DbSet<TEntry> _dbSet = context.Set<TEntry>();

        public async Task<TEntry?> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task<TEntry?> GetByIdentifier(TInputIdentifier inputIdentifier)
        {
            IQueryable<TEntry> query = _dbSet.AsNoTracking();

            foreach (var property in typeof(TInputIdentifier).GetProperties())
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(inputIdentifier);

                if (propertyValue != null)
                {
                    var parameter = Expression.Parameter(typeof(TEntry), "x");
                    var member = Expression.Property(parameter, propertyName);
                    var constant = Expression.Constant(propertyValue, member.Type);

                    var body = Expression.Equal(member, constant);
                    var lambda = Expression.Lambda<Func<TEntry, bool>>(body, parameter);

                    query = query.Where(lambda);
                }
            }

            return Task.FromResult(query.FirstOrDefault());
        }

        public async Task Add(TEntry entry)
        {
            await _dbSet.AddAsync(entry.SetCreateData());
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntry entry)
        {
            _context.Update(entry.SetChangeData());
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TEntry entry)
        {
            _dbSet.Remove(entry);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _dbSet.Remove(new TEntry { Id = id });
            await _context.SaveChangesAsync();
        }
    }
}