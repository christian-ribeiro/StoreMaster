using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TDTO : BaseDTO<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxililiaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxililiaryPropertiesDTO>, new()
    {
        public TOutput Get(long id);
        public TOutput GetByIdentifier(TInputIdentifier inputIdentifier);
        public List<TOutput> GetListByListIdentifier(List<TInputIdentifier> listInputIdentifier);
        long Create(TInputCreate inputCreate);
        List<long> Create(List<TInputCreate> listInputCreate);
        long Update(TInputUpdate inputUpdate);
        List<long> UpdateMultiple(List<TInputUpdate> listInputUpdate);
        bool Delete(TInputIdentityDelete inputIdentityDelete);
        bool DeleteMultiple(List<TInputIdentityDelete> listInputIdentityDelete);
    }

    public interface IBaseService_1<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO> : IBaseService<TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TDTO : BaseDTO_1<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>, new()
    where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
    where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
    where TAuxililiaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxililiaryPropertiesDTO>, new()
    {
    }
}
