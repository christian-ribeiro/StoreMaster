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
    }
}