using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    {
        TOutput Get(long id);
        TOutput GetByIdentifier(TInputIdentifier inputIdentifier);
        List<TOutput> GetAll();
        List<TOutput> GetListByListIdentifier(List<TInputIdentifier> listInputIdentifier);
        List<TOutput> GetListByListId(List<long> listId);
        long Create(TInputCreate inputCreate);
        List<long> Create(List<TInputCreate> listInputCreate);
        long Update(TInputIdentityUpdate inputIdentityUpdate);
        List<long> Update(List<TInputIdentityUpdate> listInputIdentityUpdate);
        bool Delete(TInputIdentityDelete inputIdentityDelete);
        bool Delete(List<TInputIdentityDelete> listInputIdentityDelete);
    }

    public interface IBaseService_1<TOutput, TInputIdentifier, TInputCreate> : IBaseService<TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    {
    }
}
