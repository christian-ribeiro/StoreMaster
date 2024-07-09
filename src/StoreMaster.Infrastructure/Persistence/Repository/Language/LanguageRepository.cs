using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class LanguageRepository(AppDbContext context) : BaseRepository_3<Language, OutputLanguage, InputIdentifierLanguage, LanguageDTO, InternalPropertiesLanguageDTO, AuxiliaryPropertiesLanguageDTO>(context), ILanguageRepository { }
}