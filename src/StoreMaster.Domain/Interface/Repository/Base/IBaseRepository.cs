namespace StoreMaster.Domain.Interface.Repository.Base
{
    public interface IBaseRepository<TEntry, TInputIdentifier>
    {
        Task<TEntry?> Get(int id);
        Task<TEntry?> GetByIdentifier(TInputIdentifier inputIdentifier);
        Task Add(TEntry entity);
        Task Update(TEntry entity);
        Task Delete(TEntry entry);
        Task Delete(int id);
    }
}