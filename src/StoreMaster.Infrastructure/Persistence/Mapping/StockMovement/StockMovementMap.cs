using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class StockMovementMap : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder.ToTable("movimento_estoque");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");

            builder.Property(x => x.StockMovementType).HasColumnName("tipo_movimento_estoque");
        }
    }
}