using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Domain.Interface.Service.Base
{
    public interface IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputReplace, TInputIdentityDelete>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputReplace : BaseInputReplace<TInputReplace>
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
        List<long> Replace(List<TInputReplace> listInputReplace);
        bool Delete(TInputIdentityDelete inputIdentityDelete);
        bool Delete(List<TInputIdentityDelete> listInputIdentityDelete);
    }

    #region TInputReplace
    public interface IBaseService_1<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, BaseInputReplace_0, TInputIdentityDelete>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    { }
    #endregion

    #region TInputUpdate TInputIdentityUpdate TInputReplace TInputIdentityDelete
    public interface IBaseService_2<TOutput, TInputIdentifier, TInputCreate> : IBaseService<TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputReplace_0, BaseInputIdentityDelete_0>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    { }
    #endregion

    #region TInputCreate TInputUpdate TInputIdentityUpdate TInputReplace TInputIdentityDelete
    public interface IBaseService_3<TOutput, TInputIdentifier> : IBaseService<TOutput, TInputIdentifier, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputReplace_0, BaseInputIdentityDelete_0>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    { }
    #endregion
}