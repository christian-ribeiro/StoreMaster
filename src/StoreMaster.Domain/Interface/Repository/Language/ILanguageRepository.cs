using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository.Base;

namespace StoreMaster.Domain.Interface.Repository
{
    public interface ILanguageRepository : IBaseRepository_2<OutputLanguage, InputIdentifierLanguage, LanguageDTO, InternalPropertiesLanguageDTO, AuxiliaryPropertiesLanguageDTO> { }
}