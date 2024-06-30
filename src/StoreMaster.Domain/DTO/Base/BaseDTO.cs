using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Domain.DTO.Base
{
    public class BaseDTO<TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TDTO : BaseDTO<TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxililiaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxililiaryPropertiesDTO>, new()
    {
        public TInternalPropertiesDTO InternalPropertiesDTO { get; set; }
        public TExternalPropertiesDTO ExternalPropertiesDTO { get; set; }
        public TAuxililiaryPropertiesDTO AuxililiaryPropertiesDTO { get; set; }

        public BaseDTO()
        {
            InternalPropertiesDTO = new TInternalPropertiesDTO();
            ExternalPropertiesDTO = new TExternalPropertiesDTO();
            AuxililiaryPropertiesDTO = new TAuxililiaryPropertiesDTO();
        }

        public TDTO Load(TInternalPropertiesDTO internalPropertiesDTO, TExternalPropertiesDTO externalPropertiesDTO, TAuxililiaryPropertiesDTO auxililiaryPropertiesDTO)
        {
            return new TDTO
            {
                ExternalPropertiesDTO = externalPropertiesDTO,
                InternalPropertiesDTO = internalPropertiesDTO,
                AuxililiaryPropertiesDTO = auxililiaryPropertiesDTO
            };
        }
    }

    public class BaseDTO_1<TOutput, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO> : BaseDTO<TOutput, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TDTO : BaseDTO_1<TOutput, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxililiaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxililiaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxililiaryPropertiesDTO>, new()
    { }
}