using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ProductCategoryDTO : BaseDTO<OutputProductCategory, InputIdentifierProductCategory, InputCreateProductCategory, InputUpdateProductCategory, InputIdentityUpdateProductCategory, InputIdentityDeleteProductCategory, ProductCategoryDTO, InternalPropertiesProductCategoryDTO, ExternalPropertiesProductCategoryDTO, AuxiliaryPropertiesProductCategoryDTO>
    {
#nullable disable
        public static ProductCategoryDTO GetDTO(OutputProductCategory output)
        {
            return output == null ? default : new ProductCategoryDTO().Load(
                new InternalPropertiesProductCategoryDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesProductCategoryDTO(output.Code, output.Description),
                new AuxiliaryPropertiesProductCategoryDTO());
        }

        public static OutputProductCategory GetOutput(ProductCategoryDTO dto)
        {
            return dto == null ? default : new OutputProductCategory(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Description, default).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator ProductCategoryDTO(OutputProductCategory output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputProductCategory(ProductCategoryDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}