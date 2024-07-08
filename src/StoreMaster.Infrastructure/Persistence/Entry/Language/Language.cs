using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class Language : BaseEntry<Language>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region NotMapped
        [NotMapped]
        public override DateTime CreationDate => base.CreationDate;
        [NotMapped]
        public override DateTime? ChangeDate => base.ChangeDate;
        [NotMapped]
        public override long CreationUserId => base.CreationUserId;
        [NotMapped]
        public override long? ChangeUserId => base.ChangeUserId;
        [NotMapped]
        public override User? CreationUser => base.CreationUser;
        [NotMapped]
        public override User? ChangeUser => base.ChangeUser;
        #endregion

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
        public static LanguageDTO GetDTO(Language language)
        {
            return language == null ? default : new LanguageDTO().Load(
                    new InternalPropertiesLanguageDTO(language.Code, language.Description).SetInternalData(language.Id),
                    default,
                    new AuxiliaryPropertiesLanguageDTO());
        }

        public static Language GetEntry(LanguageDTO dto)
        {
            return dto == null ? default : new Language(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
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