using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class StockConfigurationMap : IEntityTypeConfiguration<StockConfiguration>
    {
        public void Configure(EntityTypeBuilder<StockConfiguration> builder)
        {
            builder.ToTable("configuracao_estoque");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");

            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");

            builder.Property(x => x.MinimumStockAmount).HasColumnName("quantidade_minima_estoque");
        }
    }
}