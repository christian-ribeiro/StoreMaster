using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("categoria_produto");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.Code).HasColumnName("codigo");
            builder.Property(x => x.Code).HasMaxLength(6);
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.Description).HasColumnName("descricao");
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}