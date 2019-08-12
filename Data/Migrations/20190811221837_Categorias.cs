using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace shopWeb.Data.Migrations
{
    public partial class Categorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false),
                    login = table.Column<string>(type: "character varying", nullable: false),
                    senha = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cidades",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formapagamentos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formapagamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    situacao = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(type: "character varying", nullable: false),
                    preco = table.Column<decimal>(type: "numeric", nullable: false),
                    imagem = table.Column<string>(type: "character varying", nullable: false),
                    nome = table.Column<string>(type: "character varying", nullable: false),
                    idcategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_categorias_idcategoria",
                        column: x => x.idcategoria,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idcidade = table.Column<int>(nullable: false),
                    nome = table.Column<string>(type: "character varying", nullable: false),
                    email = table.Column<string>(nullable: false),
                    cpf = table.Column<string>(type: "character varying", nullable: false),
                    rg = table.Column<int>(nullable: false),
                    datanasc = table.Column<DateTime>(type: "date", nullable: false),
                    fone = table.Column<int>(nullable: false),
                    login = table.Column<string>(type: "character varying", nullable: false),
                    senha = table.Column<string>(type: "character varying", nullable: false),
                    logradouro = table.Column<string>(type: "character varying", nullable: false),
                    cep = table.Column<int>(nullable: false),
                    bairro = table.Column<string>(type: "character varying", nullable: false),
                    numero = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientes_cidades_idcidade",
                        column: x => x.idcidade,
                        principalTable: "cidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idcliente = table.Column<int>(nullable: false),
                    idformapag = table.Column<int>(nullable: false),
                    frete = table.Column<string>(type: "character varying", nullable: false),
                    total = table.Column<string>(type: "character varying", nullable: false),
                    idstatus = table.Column<int>(nullable: false),
                    data = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_idcliente",
                        column: x => x.idcliente,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_formapagamentos_idformapag",
                        column: x => x.idformapag,
                        principalTable: "formapagamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_status_idstatus",
                        column: x => x.idstatus,
                        principalTable: "status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itenspedidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idproduto = table.Column<int>(nullable: false),
                    idpedido = table.Column<int>(nullable: false),
                    quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itenspedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_itenspedidos_pedidos_idpedido",
                        column: x => x.idpedido,
                        principalTable: "pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itenspedidos_produtos_idproduto",
                        column: x => x.idproduto,
                        principalTable: "produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_idcidade",
                table: "clientes",
                column: "idcidade");

            migrationBuilder.CreateIndex(
                name: "IX_itenspedidos_idpedido",
                table: "itenspedidos",
                column: "idpedido");

            migrationBuilder.CreateIndex(
                name: "IX_itenspedidos_idproduto",
                table: "itenspedidos",
                column: "idproduto");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idcliente",
                table: "pedidos",
                column: "idcliente");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idformapag",
                table: "pedidos",
                column: "idformapag");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idstatus",
                table: "pedidos",
                column: "idstatus");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idcategoria",
                table: "produtos",
                column: "idcategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "itenspedidos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "formapagamentos");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "cidades");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);
        }
    }
}
