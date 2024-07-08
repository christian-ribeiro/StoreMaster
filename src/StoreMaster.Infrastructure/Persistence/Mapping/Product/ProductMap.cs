using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("produto");

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.ListProduct).HasForeignKey(x => x.ProductCategoryId);

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.CreationDate).IsRequired();

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.Description).HasColumnName("descricao");
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.ProductCategoryId).HasColumnName("id_categoria_produto");
        }
    }
}