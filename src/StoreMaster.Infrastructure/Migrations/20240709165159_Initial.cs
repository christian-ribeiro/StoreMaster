using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreMaster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "idioma",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    path = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    label = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    posicao = table.Column<int>(type: "int", nullable: false),
                    visivel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dica = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    id_pai = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "status_usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_movimento_estoque",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    senha = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    atualizacao_token = table.Column<string>(type: "longtext", nullable: true),
                    id_idioma = table.Column<long>(type: "bigint", nullable: false),
                    id_status_usuario = table.Column<long>(type: "bigint", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_idioma_id_idioma",
                        column: x => x.id_idioma,
                        principalTable: "idioma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_status_usuario_id_status_usuario",
                        column: x => x.id_status_usuario,
                        principalTable: "status_usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoria_produto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    descricao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    id_usuario_criacao = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario_alteracao = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categoria_produto_usuario_id_usuario_alteracao",
                        column: x => x.id_usuario_alteracao,
                        principalTable: "usuario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_categoria_produto_usuario_id_usuario_criacao",
                        column: x => x.id_usuario_criacao,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "menu_usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    posicao = table.Column<int>(type: "int", nullable: false),
                    posicao_secundaria = table.Column<int>(type: "int", nullable: false),
                    favorito = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    visivel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    id_menu = table.Column<long>(type: "bigint", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    id_usuario_criacao = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario_alteracao = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menu_usuario_menu_id_menu",
                        column: x => x.id_menu,
                        principalTable: "menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_menu_usuario_usuario_id_usuario_alteracao",
                        column: x => x.id_usuario_alteracao,
                        principalTable: "usuario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_menu_usuario_usuario_id_usuario_criacao",
                        column: x => x.id_usuario_criacao,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    id_categoria_produto = table.Column<long>(type: "bigint", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    id_usuario_criacao = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario_alteracao = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produto_categoria_produto_id_categoria_produto",
                        column: x => x.id_categoria_produto,
                        principalTable: "categoria_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_usuario_id_usuario_alteracao",
                        column: x => x.id_usuario_alteracao,
                        principalTable: "usuario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_produto_usuario_id_usuario_criacao",
                        column: x => x.id_usuario_criacao,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "configuracao_estoque",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    quantidade_minima_estoque = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    id_produto = table.Column<long>(type: "bigint", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    id_usuario_criacao = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario_alteracao = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_configuracao_estoque_produto_id_produto",
                        column: x => x.id_produto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_configuracao_estoque_usuario_id_usuario_alteracao",
                        column: x => x.id_usuario_alteracao,
                        principalTable: "usuario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_configuracao_estoque_usuario_id_usuario_criacao",
                        column: x => x.id_usuario_criacao,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movimento_estoque",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sequencia = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    id_produto = table.Column<long>(type: "bigint", nullable: false),
                    id_tipo_movimento_estoque = table.Column<long>(type: "bigint", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    id_usuario_criacao = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movimento_estoque_produto_id_produto",
                        column: x => x.id_produto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimento_estoque_tipo_movimento_estoque_id_tipo_movimento_e~",
                        column: x => x.id_tipo_movimento_estoque,
                        principalTable: "tipo_movimento_estoque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimento_estoque_usuario_id_usuario_criacao",
                        column: x => x.id_usuario_criacao,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "idioma",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1L, "001", "Português" },
                    { 2L, "002", "English" },
                    { 3L, "003", "Español" }
                });

            migrationBuilder.InsertData(
                table: "menu",
                columns: new[] { "Id", "label", "id_pai", "path", "posicao", "dica", "visivel" },
                values: new object[,]
                {
                    { 1L, "Cadastro", null, "/Cadastro", 1, "", true },
                    { 2L, "Produto", 1L, "/Produto", 1, "", true },
                    { 3L, "Categoria do Produto", 1L, "/CategoriaProduto", 2, "", true },
                    { 4L, "Usuário", 1L, "/Usuario", 3, "", true },
                    { 20L, "Configuração", null, "/Configuração", 2, "", true },
                    { 21L, "Configuração do Estoque", 20L, "/Estoque", 1, "", true },
                    { 40L, "Estoque", null, "/Estoque", 2, "", true },
                    { 41L, "Movimentação de Estoque", 40L, "/Movimentacao", 1, "", true }
                });

            migrationBuilder.InsertData(
                table: "status_usuario",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1L, "001", "Ativo" },
                    { 2L, "002", "Inativo" }
                });

            migrationBuilder.InsertData(
                table: "tipo_movimento_estoque",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1L, "001", "Entrada" },
                    { 2L, "002", "Saída" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoria_produto_id_usuario_alteracao",
                table: "categoria_produto",
                column: "id_usuario_alteracao");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_produto_id_usuario_criacao",
                table: "categoria_produto",
                column: "id_usuario_criacao");

            migrationBuilder.CreateIndex(
                name: "IX_configuracao_estoque_id_produto",
                table: "configuracao_estoque",
                column: "id_produto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_configuracao_estoque_id_usuario_alteracao",
                table: "configuracao_estoque",
                column: "id_usuario_alteracao");

            migrationBuilder.CreateIndex(
                name: "IX_configuracao_estoque_id_usuario_criacao",
                table: "configuracao_estoque",
                column: "id_usuario_criacao");

            migrationBuilder.CreateIndex(
                name: "IX_menu_usuario_id_menu",
                table: "menu_usuario",
                column: "id_menu");

            migrationBuilder.CreateIndex(
                name: "IX_menu_usuario_id_usuario_alteracao",
                table: "menu_usuario",
                column: "id_usuario_alteracao");

            migrationBuilder.CreateIndex(
                name: "IX_menu_usuario_id_usuario_criacao",
                table: "menu_usuario",
                column: "id_usuario_criacao");

            migrationBuilder.CreateIndex(
                name: "IX_movimento_estoque_id_produto",
                table: "movimento_estoque",
                column: "id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_movimento_estoque_id_tipo_movimento_estoque",
                table: "movimento_estoque",
                column: "id_tipo_movimento_estoque");

            migrationBuilder.CreateIndex(
                name: "IX_movimento_estoque_id_usuario_criacao",
                table: "movimento_estoque",
                column: "id_usuario_criacao");

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_categoria_produto",
                table: "produto",
                column: "id_categoria_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_usuario_alteracao",
                table: "produto",
                column: "id_usuario_alteracao");

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_usuario_criacao",
                table: "produto",
                column: "id_usuario_criacao");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_id_idioma",
                table: "usuario",
                column: "id_idioma");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_id_status_usuario",
                table: "usuario",
                column: "id_status_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "configuracao_estoque");

            migrationBuilder.DropTable(
                name: "menu_usuario");

            migrationBuilder.DropTable(
                name: "movimento_estoque");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "tipo_movimento_estoque");

            migrationBuilder.DropTable(
                name: "categoria_produto");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "idioma");

            migrationBuilder.DropTable(
                name: "status_usuario");
        }
    }
}
