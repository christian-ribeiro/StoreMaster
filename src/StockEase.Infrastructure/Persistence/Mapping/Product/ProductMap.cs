using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListCreationUserProduct).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListChangeUserProduct).HasForeignKey(x => x.ChangeUserId);
            builder.HasOne(x => x.ProductCategory).WithMany(x => x.ListProduct).HasForeignKey(x => x.ProductCategoryId);

            builder.ToTable("produto");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.CreationDate).IsRequired();

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.CreationUserId).HasColumnName("id_usuario_criacao");
            builder.Property(x => x.CreationUserId).IsRequired();

            builder.Property(x => x.ChangeUserId).HasColumnName("id_usuario_alteracao");

            builder.Property(x => x.Description).HasColumnName("descricao");
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.ProductCategoryId).HasColumnName("id_categoria_produto");
        }
    }
}