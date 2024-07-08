using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class LanguageMap : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("idioma");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Code).HasMaxLength(6);
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();

            builder.HasData(new List<Language>
            {
                new Language("001", "Português", default).SetInternalData(1, default, default),
                new Language("002", "English", default).SetInternalData(2, default, default),
                new Language("003", "Español", default).SetInternalData(3, default, default),
            });
        }
    }
}