using Microsoft.EntityFrameworkCore;
using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Interface.Repository.Base;
using StoreMaster.Infrastructure.Extension;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Linq.Expressions;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public abstract class BaseRepository<TEntry, TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>(AppDbContext context) : IBaseRepository<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>
        where TEntry : BaseEntry<TEntry>, new()
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TDTO : BaseDTO<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()

    {
        protected readonly AppDbContext _context = context;
        protected DbSet<TEntry> _dbSet = context.Set<TEntry>();

        public long Create(TDTO dto)
        {
            return Create([dto]).FirstOrDefault();
        }

        public List<long> Create(List<TDTO> listDTO)
        {
            List<TEntry> listEntry = FromDTOToEntry(listDTO);
            _dbSet.AddRange(listEntry);
            _context.SaveChanges();

            return (from i in listEntry select i.Id).ToList();
        }

        public bool Delete(TDTO dto)
        {
            return Delete([dto]);
        }

        public bool Delete(List<TDTO> listDTO)
        {
            List<TEntry> listEntry = FromDTOToEntry(listDTO);
            _dbSet.RemoveRange(listEntry);
            _context.SaveChanges();

            return true;
        }

        public TDTO Get(long id)
        {
            var query = _dbSet.AsNoTracking().Where(x => x.Id == id).IncludeVirtualProperties().FirstOrDefault();
            return FromEntryToDTO(query);
        }

        public List<TDTO> GetAll()
        {
            return FromEntryToDTO(_dbSet.AsNoTracking().IncludeVirtualProperties().ToList());
        }

        public List<TDTO> GetListByListId(List<long> listId)
        {
            return FromEntryToDTO(_dbSet.Where(x => listId.Contains(x.Id)).IncludeVirtualProperties().AsNoTracking().ToList());
        }

        public TDTO GetByIdentifier(TInputIdentifier inputIdentifier)
        {
            return GetListByListIdentifier([inputIdentifier]).FirstOrDefault();
        }

        public List<TDTO> GetListByListIdentifier(List<TInputIdentifier> listInputIdentifier)
        {
            IQueryable<TEntry> query = _dbSet.AsNoTracking();

            if (listInputIdentifier == null || !listInputIdentifier.Any())
            {
                return new List<TDTO>();
            }

            Expression<Func<TEntry, bool>> combinedExpression = null;

            foreach (var inputIdentifier in listInputIdentifier)
            {
                Expression<Func<TEntry, bool>> individualExpression = null;

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

                        individualExpression = individualExpression == null ? lambda : CombineExpressions(individualExpression, lambda);
                    }
                }

                combinedExpression = combinedExpression == null ? individualExpression : CombineExpressions(combinedExpression, individualExpression, Expression.OrElse);
            }

            query = query.Where(combinedExpression).IncludeVirtualProperties();

            return FromEntryToDTO(query.ToList());
        }

        private static Expression<Func<T, bool>> CombineExpressions<T>(
            Expression<Func<T, bool>> expr1,
            Expression<Func<T, bool>> expr2,
            Func<Expression, Expression, BinaryExpression> combiner = null)
        {
            combiner = combiner ?? Expression.AndAlso;

            var parameter = Expression.Parameter(typeof(T), "x");

            var leftVisitor = new ReplaceParameterVisitor(expr1.Parameters[0], parameter);
            var left = leftVisitor.Visit(expr1.Body);

            var rightVisitor = new ReplaceParameterVisitor(expr2.Parameters[0], parameter);
            var right = rightVisitor.Visit(expr2.Body);

            return Expression.Lambda<Func<T, bool>>(combiner(left, right), parameter);
        }

        private class ReplaceParameterVisitor(ParameterExpression oldParameter, ParameterExpression newParameter) : ExpressionVisitor
        {
            private readonly ParameterExpression _oldParameter = oldParameter;
            private readonly ParameterExpression _newParameter = newParameter;

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return node == _oldParameter ? _newParameter : base.VisitParameter(node);
            }
        }

        public long Update(TDTO dto)
        {
            return Update([dto]).FirstOrDefault();
        }

        public List<long> Update(List<TDTO> listDTO)
        {
            List<TEntry> listEntry = FromDTOToEntry(listDTO);
            _dbSet.UpdateRange(listEntry);
            _context.SaveChanges();

            return (from i in listEntry select i.Id).ToList();
        }

        internal TEntry FromDTOToEntry(TDTO dto)
        {
            return (TEntry)(dynamic)dto;
        }

        internal TDTO FromEntryToDTO(TEntry entry)
        {
            return (TDTO)(dynamic)entry;
        }

        internal List<TEntry> FromDTOToEntry(List<TDTO> listDTO)
        {
            return (from i in listDTO select (TEntry)(dynamic)i).ToList();
        }

        internal List<TDTO> FromEntryToDTO(List<TEntry> listEntry)
        {
            return (from i in listEntry select (TDTO)(dynamic)i).ToList();
        }


    }

    public abstract class BaseRepository_1<TEntry, TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>(AppDbContext context) : BaseRepository<TEntry, TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>(context), IBaseRepository_1<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>
    where TEntry : BaseEntry<TEntry>, new()
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TDTO : BaseDTO_1<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
    where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
    where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
    where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()

    { }
}