using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Interface.Repository.Base;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.Domain.Service.Base
{
    public class BaseService<TRepository, TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>(TRepository repository) : IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
        where TRepository : IBaseRepository<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
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
        protected readonly TRepository _repository = repository;

        public virtual TOutput Get(long id)
        {
            return FromDTOToOutput(_repository.Get(id));
        }

        public virtual TOutput GetByIdentifier(TInputIdentifier inputIdentifier)
        {
            return FromDTOToOutput(_repository.GetByIdentifier(inputIdentifier));
        }

        public virtual List<TOutput> GetAll()
        {
            return FromDTOToOutput(_repository.GetAll());
        }

        public virtual List<TOutput> GetListByListIdentifier(List<TInputIdentifier> listInputIdentifier)
        {
            return FromDTOToOutput(_repository.GetListByListIdentifier(listInputIdentifier));
        }

        public virtual List<TOutput> GetListByListId(List<long> listId)
        {
            return FromDTOToOutput(_repository.GetListByListId(listId));
        }

        public long Create(TInputCreate inputCreate)
        {
            return Create([inputCreate]).FirstOrDefault();
        }

        public virtual List<long> Create(List<TInputCreate> listInputCreate)
        {
            throw new NotImplementedException();
        }
        public virtual long Update(TInputIdentityUpdate inputIdentityUpdate)
        {
            return Update([inputIdentityUpdate]).FirstOrDefault();
        }

        public virtual List<long> Update(List<TInputIdentityUpdate> listInputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TInputIdentityDelete inputIdentityDelete)
        {
            return Delete([inputIdentityDelete]);
        }

        public virtual bool Delete(List<TInputIdentityDelete> listInputIdentityDelete)
        {
            throw new NotImplementedException();
        }

        internal TOutput FromDTOToOutput(TDTO dto)
        {
            return (TOutput)(dynamic)dto;
        }

        internal List<TOutput> FromDTOToOutput(List<TDTO> listDTO)
        {
            return (from i in listDTO select (TOutput)(dynamic)i).ToList();
        }
    }

    public class BaseService_1<TRepository, TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>(TRepository repository) : BaseService<TRepository, TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>(repository), IBaseService_1<TOutput, TInputIdentifier, TInputCreate>
        where TRepository : IBaseRepository_1<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
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