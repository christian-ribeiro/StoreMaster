﻿namespace StoreMaster.Domain.DTO.Base
{
    public abstract class BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertyDTO> where TAuxiliaryPropertyDTO : BaseAuxiliaryPropertiesDTO<TAuxiliaryPropertyDTO>, new() { }
}