using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Mapping
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("menu");

            builder.Property(x => x.Path).HasColumnName("path");
            builder.Property(x => x.Path).HasMaxLength(100);
            builder.Property(x => x.Path).IsRequired();

            builder.Property(x => x.Label).HasColumnName("label");
            builder.Property(x => x.Label).HasMaxLength(100);
            builder.Property(x => x.Label).IsRequired();

            builder.Property(x => x.Position).HasColumnName("posicao");
            builder.Property(x => x.Position).IsRequired();

            builder.Property(x => x.Visible).HasColumnName("visivel");
            builder.Property(x => x.Visible).IsRequired();

            builder.Property(x => x.ToolTip).HasColumnName("dica");
            builder.Property(x => x.ToolTip).HasMaxLength(200);

            builder.Property(x => x.ParentId).HasColumnName("id_pai");

            builder.HasData(new List<Menu>
            {
                new Menu("/Cadastro", "Cadastro", 1, true, "", null).SetInternalData(1),
                new Menu("/Produto", "Produto", 1, true, "", 1).SetInternalData(2),
                new Menu("/CategoriaProduto", "Categoria do Produto", 2, true, "", 1).SetInternalData(3),
                new Menu("/Usuario", "Usuário", 3, true, "", 1).SetInternalData(4),

                new Menu("/Configuração", "Configuração", 2, true, "", null).SetInternalData(20),
                new Menu("/Estoque", "Configuração do Estoque", 1, true, "", 20).SetInternalData(21),

                new Menu("/Estoque", "Estoque", 2, true, "", null).SetInternalData(40),
                new Menu("/Movimentacao", "Movimentação de Estoque", 1, true, "", 40).SetInternalData(41),
            });
        }
    }
}