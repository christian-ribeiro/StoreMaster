using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class StockMovementMap : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder.HasOne(x => x.StockMovementType).WithMany(x => x.ListStockMovement).HasForeignKey(x => x.StockMovementTypeId);
            builder.HasOne(x => x.Product).WithMany(x => x.ListStockMovement).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("movimento_estoque");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.CreationDate).IsRequired();

            builder.Property(x => x.StockMovementTypeId).HasColumnName("id_tipo_movimento_estoque");
            builder.Property(x => x.StockMovementTypeId).IsRequired();

            builder.Property(x => x.ProductId).HasColumnName("id_produto");
            builder.Property(x => x.ProductId).IsRequired();
        }
    }
}