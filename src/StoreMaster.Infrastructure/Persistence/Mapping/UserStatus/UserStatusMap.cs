using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class UserStatusMap : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            builder.ToTable("status_usuario");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Code).HasMaxLength(6);
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();

            builder.HasData(new List<UserStatus>
            {
                new UserStatus("001", "Ativo").SetInternalData(1),
                new UserStatus("002", "Inativo").SetInternalData(2),
            });
        }
    }
}