using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ProductDTO : BaseDTO<OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>
    {
#nullable disable
        public static ProductDTO GetDTO(OutputProduct output)
        {
            return output == null ? default : new ProductDTO().Load(
                new InternalPropertiesProductDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesProductDTO(output.ProductCategoryId),
                new AuxiliaryPropertiesProductDTO(output.ProductCategory));
        }

        public static OutputProduct GetOutput(ProductDTO dto)
        {
            return dto == null ? default : new OutputProduct(dto.ExternalPropertiesDTO.ProductCategoryId, dto.AuxililiaryPropertiesDTO.ProductCategory).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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
