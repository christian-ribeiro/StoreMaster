using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ProductDTO : BaseDTO_1<OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>
    {
#nullable disable
        public static ProductDTO GetDTO(OutputProduct output)
        {
            return output == null ? default : new ProductDTO().Load(
                new InternalPropertiesProductDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate, output.CreationUserId, output.ChangeUserId),
                new ExternalPropertiesProductDTO(output.Description, output.ProductCategoryId),
                new AuxiliaryPropertiesProductDTO(output.ProductCategory).SetInternalData(output.CreationUser, output.ChangeUser));
        }

        public static OutputProduct GetOutput(ProductDTO dto)
        {
            return dto == null ? default : new OutputProduct(dto.ExternalPropertiesDTO.Description, dto.ExternalPropertiesDTO.ProductCategoryId, dto.AuxiliaryPropertiesDTO.ProductCategory)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
        }

        public static implicit operator ProductDTO(OutputProduct output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputProduct(ProductDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}
