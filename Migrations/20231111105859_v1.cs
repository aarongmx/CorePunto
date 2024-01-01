using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CorePuntoVenta.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abonos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    monto = table.Column<float>(type: "real", nullable: false),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_abonos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cuentas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    saldo = table.Column<float>(type: "real", nullable: false),
                    adeudo = table.Column<float>(type: "real", nullable: false),
                    cliente_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cuentas", x => x.id);
                    table.ForeignKey(
                        name: "fk_cuentas_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "estatus_orden",
                keyColumn: "id",
                keyValue: 2,
                column: "nombre",
                value: "PENDIENTE");

            migrationBuilder.InsertData(
                table: "estatus_orden",
                columns: new[] { "id", "created_at", "deleted_at", "nombre", "updated_at" },
                values: new object[] { 3, null, null, "PAGADA", null });

            migrationBuilder.InsertData(
                table: "metodos_pago",
                columns: new[] { "id", "created_at", "deleted_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "EFECTIVO", null },
                    { 2, null, null, "TARJETA DE CRÉDITO/DEBITO", null },
                    { 3, null, null, "CHEQUE", null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_cuentas_cliente_id",
                table: "cuentas",
                column: "cliente_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abonos");

            migrationBuilder.DropTable(
                name: "cuentas");

            migrationBuilder.DeleteData(
                table: "estatus_orden",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "metodos_pago",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "metodos_pago",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "metodos_pago",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "estatus_orden",
                keyColumn: "id",
                keyValue: 2,
                column: "nombre",
                value: "PAGADA");
        }
    }
}
