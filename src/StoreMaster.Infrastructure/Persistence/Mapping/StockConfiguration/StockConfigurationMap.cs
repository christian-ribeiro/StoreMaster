using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class StockConfigurationMap : IEntityTypeConfiguration<StockConfiguration>
    {
        public void Configure(EntityTypeBuilder<StockConfiguration> builder)
        {
            builder.HasOne(x => x.CreationUser).WithMany(x => x.ListCreationUserStockConfiguration).HasForeignKey(x => x.CreationUserId);
            builder.HasOne(x => x.ChangeUser).WithMany(x => x.ListChangeUserStockConfiguration).HasForeignKey(x => x.ChangeUserId);
            builder.HasOne(x => x.Product).WithOne(x => x.StockConfiguration).HasForeignKey<StockConfiguration>(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("configuracao_estoque");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.CreationDate).IsRequired();

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.CreationUserId).HasColumnName("id_usuario_criacao");
            builder.Property(x => x.CreationUserId).IsRequired();

            builder.Property(x => x.ChangeUserId).HasColumnName("id_usuario_alteracao");

            builder.Property(x => x.MinimumStockAmount).HasColumnName("quantidade_minima_estoque");

            builder.Property(x => x.ProductId).HasColumnName("id_produto");
            builder.Property(x => x.ProductId).IsRequired();
        }
    }
}