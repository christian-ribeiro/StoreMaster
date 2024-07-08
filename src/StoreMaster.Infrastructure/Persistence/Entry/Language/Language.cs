using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class Language : BaseEntry<Language>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region Virtual Properties
        #region External
        public virtual List<User> ListUser { get; private set; }
        #endregion
        #endregion

        public Language() { }

        public Language(string code, string description, List<User> listUser)
        {
            Code = code;
            Description = description;
            ListUser = listUser;
        }

#nullable disable
        public static LanguageDTO GetDTO(Language language)
        {
            return language == null ? default : new LanguageDTO().Load(
                    new InternalPropertiesLanguageDTO(language.Code, language.Description).SetInternalData(language.Id),
                    default,
                    new AuxiliaryPropertiesLanguageDTO(language.ListUser.ConvertAll<UserDTO>())
                );
        }

        public static Language GetEntry(LanguageDTO dto)
        {
            return dto == null ? default : new Language(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, dto.AuxiliaryPropertiesDTO.ListUser.ConvertAll<User>())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator LanguageDTO(Language language)
        {
            return GetDTO(language);
        }

        public static implicit operator Language(LanguageDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}