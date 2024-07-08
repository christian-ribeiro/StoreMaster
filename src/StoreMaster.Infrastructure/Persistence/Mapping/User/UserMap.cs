using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.Language).WithMany(x => x.ListUser).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.UserStatus).WithMany(x => x.ListUser).HasForeignKey(x => x.UserStatusId);

            builder.ToTable("usuario");

            builder.HasKey(x => x.Id);

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.CreationDate).IsRequired();

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.Code).HasColumnName("codigo");
            builder.Property(x => x.Code).HasMaxLength(6);
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.Name).HasColumnName("nome");
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Password).HasColumnName("senha");
            builder.Property(x => x.Password).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired();

            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.Email).IsRequired();

            builder.Property(x => x.RefreshToken).HasColumnName("atualizacao_token");

            builder.Property(x => x.LanguageId).HasColumnName("id_idioma");
            builder.Property(x => x.LanguageId).IsRequired();

            builder.Property(x => x.UserStatusId).HasColumnName("id_status_usuario");
            builder.Property(x => x.UserStatusId).IsRequired();
        }
    }
}