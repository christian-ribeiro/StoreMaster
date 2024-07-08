using StoreMaster.Domain.DTO;
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

        public Language(string code, string description)
        {
            Code = code;
            Description = description;
        }

#nullable disable
        public LanguageDTO GetDTO()
        {
            return new LanguageDTO().Load(
                    new InternalPropertiesLanguageDTO(Code, Description).SetInternalData(Id),
                    default,
                    new AuxiliaryPropertiesLanguageDTO()
                );
        }

        public Language GetEntry(LanguageDTO dto)
        {
            return dto == null ? default : new Language(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator LanguageDTO(Language language)
        {
            return new Language().GetDTO();
        }

        public static implicit operator Language(LanguageDTO dto)
        {
            return new Language().GetEntry(dto);
        }
#nullable enable
    }
}