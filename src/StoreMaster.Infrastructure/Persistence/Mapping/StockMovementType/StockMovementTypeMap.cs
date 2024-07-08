using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class StockMovementTypeMap : IEntityTypeConfiguration<StockMovementType>
    {
        public void Configure(EntityTypeBuilder<StockMovementType> builder)
        {
            builder.ToTable("tipo_movimento_estoque");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Code).HasMaxLength(6);
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();

            builder.HasData(new List<StockMovementType>
            {
                new StockMovementType("001", "Entrada").SetInternalData(1),
                new StockMovementType("002", "Saída").SetInternalData(2),
            });
        }
    }
}