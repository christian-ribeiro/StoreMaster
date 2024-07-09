using StoreMaster.Arguments.Arguments.Base;
using System.Reflection;

namespace StoreMaster.Domain.DTO.Base
{
    public class BaseDTO_0<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputReplace, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputReplace : BaseInputReplace<TInputReplace>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
        where TDTO : BaseDTO_0<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputReplace, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()
    {
        public TInternalPropertiesDTO InternalPropertiesDTO { get; set; }
        public TExternalPropertiesDTO ExternalPropertiesDTO { get; set; }
        public TAuxiliaryPropertiesDTO AuxiliaryPropertiesDTO { get; set; }

        public BaseDTO_0()
        {
            InternalPropertiesDTO = new TInternalPropertiesDTO();
            ExternalPropertiesDTO = new TExternalPropertiesDTO();
            AuxiliaryPropertiesDTO = new TAuxiliaryPropertiesDTO();
        }

        public TDTO Create(TInputCreate inputCreate, TInternalPropertiesDTO internalPropertiesDTO = null, TAuxiliaryPropertiesDTO auxiliaryPropertiesDTO = null)
        {
            foreach (PropertyInfo item in ExternalPropertiesDTO.GetType().GetProperties().ToList())
            {
                var propertyValue = inputCreate.GetType().GetProperty(item.Name)?.GetValue(inputCreate);

                if (propertyValue != null)
                    item.SetValue(ExternalPropertiesDTO, propertyValue);
            }

            if (internalPropertiesDTO != null)
                InternalPropertiesDTO = internalPropertiesDTO;
            else
                InternalPropertiesDTO = new TInternalPropertiesDTO();

            InternalPropertiesDTO.SetCreateData();

            if (auxiliaryPropertiesDTO != null)
                AuxiliaryPropertiesDTO = auxiliaryPropertiesDTO;

            return (TDTO)this;
        }

        public TDTO Replace(TInputReplace inputReplace, TInternalPropertiesDTO internalPropertiesDTO = null, TAuxiliaryPropertiesDTO auxiliaryPropertiesDTO = null)
        {
            foreach (PropertyInfo item in ExternalPropertiesDTO.GetType().GetProperties().ToList())
            {
                var propertyValue = inputReplace.GetType().GetProperty(item.Name)?.GetValue(inputReplace);

                if (propertyValue != null)
                    item.SetValue(ExternalPropertiesDTO, propertyValue);
            }

            if (internalPropertiesDTO != null)
                InternalPropertiesDTO = internalPropertiesDTO;
            else
                InternalPropertiesDTO = new TInternalPropertiesDTO();

            InternalPropertiesDTO.SetCreateData();

            if (auxiliaryPropertiesDTO != null)
                AuxiliaryPropertiesDTO = auxiliaryPropertiesDTO;

            return (TDTO)this;
        }

        public TDTO Create(long id, TExternalPropertiesDTO externalPropertiesDTO, TInternalPropertiesDTO internalPropertiesDTO = default(TInternalPropertiesDTO), TAuxiliaryPropertiesDTO auxiliaryPropertiesDTO = default(TAuxiliaryPropertiesDTO))
        {
            ExternalPropertiesDTO = externalPropertiesDTO;
            if (internalPropertiesDTO != null)
                InternalPropertiesDTO = internalPropertiesDTO;

            if (auxiliaryPropertiesDTO != null)
                AuxiliaryPropertiesDTO = auxiliaryPropertiesDTO;

            InternalPropertiesDTO.SetCreateData();

            return (TDTO)this;
        }

        public TDTO Update(TInputUpdate inputUpdate, TInternalPropertiesDTO internalPropertiesDTO = null, TAuxiliaryPropertiesDTO auxiliaryPropertiesDTO = null)
        {
            foreach (PropertyInfo item in ExternalPropertiesDTO.GetType().GetProperties().ToList())
            {
                var propertyValue = inputUpdate.GetType().GetProperty(item.Name)?.GetValue(inputUpdate);

                if (propertyValue != null)
                    item.SetValue(ExternalPropertiesDTO, propertyValue);
            }

            if (internalPropertiesDTO != null)
                InternalPropertiesDTO = internalPropertiesDTO;

            if (auxiliaryPropertiesDTO != null)
                AuxiliaryPropertiesDTO = auxiliaryPropertiesDTO;

            InternalPropertiesDTO.SetUpdateData();

            return (TDTO)this;
        }

        public TDTO Update(TExternalPropertiesDTO externalPropertiesDTO, TInternalPropertiesDTO internalPropertiesDTO = null, TAuxiliaryPropertiesDTO auxiliaryPropertiesDTO = null)
        {
            ExternalPropertiesDTO = externalPropertiesDTO;

            if (internalPropertiesDTO != null)
                InternalPropertiesDTO = internalPropertiesDTO;

            if (auxiliaryPropertiesDTO != null)
                AuxiliaryPropertiesDTO = auxiliaryPropertiesDTO;

            InternalPropertiesDTO.SetUpdateData();

            return (TDTO)this;
        }

        public TDTO Load(TInternalPropertiesDTO internalPropertiesDTO, TExternalPropertiesDTO externalPropertiesDTO, TAuxiliaryPropertiesDTO AuxiliaryPropertiesDTO)
        {
            return new TDTO
            {
                ExternalPropertiesDTO = externalPropertiesDTO,
                InternalPropertiesDTO = internalPropertiesDTO,
                AuxiliaryPropertiesDTO = AuxiliaryPropertiesDTO
            };
        }
    }

    #region TInputReplace
    public class BaseDTO_1<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO> : BaseDTO_0<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, BaseInputReplace_0, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TDTO : BaseDTO_1<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
    where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
    where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
    where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()
    { }
    #endregion

    #region TInputUpdate TInputIdentityUpdate TInputIdentityDelete
    public class BaseDTO_2<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO> : BaseDTO_0<TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputReplace_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TDTO : BaseDTO_2<TOutput, TInputIdentifier, TInputCreate, TDTO, TInternalPropertiesDTO, TExternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
        where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()
    { }
    #endregion

    #region TInputCreate TInputUpdate TInputIdentityUpdate TInputIdentityDelete TExternalPropertiesDTO
    public class BaseDTO_3<TOutput, TInputIdentifier, TDTO, TInternalPropertiesDTO, TAuxiliaryPropertiesDTO> : BaseDTO_0<TOutput, TInputIdentifier, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputReplace_0, BaseInputIdentityDelete_0, TDTO, TInternalPropertiesDTO, BaseExternalPropertiesDTO_0, TAuxiliaryPropertiesDTO>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TDTO : BaseDTO_3<TOutput, TInputIdentifier, TDTO, TInternalPropertiesDTO, TAuxiliaryPropertiesDTO>, new()
        where TInternalPropertiesDTO : BaseInternalPropertiesDTO<TInternalPropertiesDTO>, new()
        where TAuxiliaryPropertiesDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertiesDTO>, new()
    { }
    #endregion
}