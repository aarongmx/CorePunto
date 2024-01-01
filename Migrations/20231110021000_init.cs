using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CorePuntoVenta.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "direcciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    calle = table.Column<string>(type: "text", nullable: true),
                    numero_externo = table.Column<string>(type: "text", nullable: false),
                    numero_interior = table.Column<string>(type: "text", nullable: true),
                    codigo_postal = table.Column<string>(type: "text", nullable: false),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_direcciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estatus_orden",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_estatus_orden", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "metodos_pago",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_metodos_pago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "referecias_orden",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    folio = table.Column<int>(type: "integer", nullable: false),
                    prefijo = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_referecias_orden", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    precio_unitario = table.Column<double>(type: "double precision", nullable: false),
                    categoria_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_productos", x => x.id);
                    table.ForeignKey(
                        name: "fk_productos_categorias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rfc = table.Column<string>(type: "text", nullable: false),
                    razon_social = table.Column<string>(type: "text", nullable: false),
                    nombre_comercial = table.Column<string>(type: "text", nullable: true),
                    direccion_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clientes", x => x.id);
                    table.ForeignKey(
                        name: "fk_clientes_direcciones_direccion_id",
                        column: x => x.direccion_id,
                        principalTable: "direcciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sucursales",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    direccion_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sucursales", x => x.id);
                    table.ForeignKey(
                        name: "fk_sucursales_direcciones_direccion_id",
                        column: x => x.direccion_id,
                        principalTable: "direcciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cajas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero_caja = table.Column<string>(type: "text", nullable: false),
                    efectivo_disponible = table.Column<double>(type: "double precision", nullable: false),
                    sucursal_id = table.Column<int>(type: "integer", nullable: false),
                    ip = table.Column<string>(type: "text", nullable: false),
                    hostname = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cajas", x => x.id);
                    table.ForeignKey(
                        name: "fk_cajas_sucursales_sucursal_id",
                        column: x => x.sucursal_id,
                        principalTable: "sucursales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    sucursal_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_empleados", x => x.id);
                    table.ForeignKey(
                        name: "fk_empleados_sucursales_sucursal_id",
                        column: x => x.sucursal_id,
                        principalTable: "sucursales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    correo = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    token = table.Column<string>(type: "text", nullable: true),
                    rol_id = table.Column<int>(type: "integer", nullable: false),
                    sucursal_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuarios_roles_rol_id",
                        column: x => x.rol_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_usuarios_sucursales_sucursal_id",
                        column: x => x.sucursal_id,
                        principalTable: "sucursales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cortes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    monto_inicial = table.Column<double>(type: "double precision", nullable: false),
                    monto_en_caja = table.Column<double>(type: "double precision", nullable: false),
                    monto_corte = table.Column<double>(type: "double precision", nullable: false),
                    caja_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cortes", x => x.id);
                    table.ForeignKey(
                        name: "fk_cortes_cajas_caja_id",
                        column: x => x.caja_id,
                        principalTable: "cajas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items_caja",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movimiento = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<double>(type: "double precision", nullable: false),
                    motivo = table.Column<string>(type: "text", nullable: true),
                    empleado_id = table.Column<int>(type: "integer", nullable: false),
                    caja_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_items_caja", x => x.id);
                    table.ForeignKey(
                        name: "fk_items_caja_cajas_caja_id",
                        column: x => x.caja_id,
                        principalTable: "cajas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_items_caja_empleados_empleado_id",
                        column: x => x.empleado_id,
                        principalTable: "empleados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordenes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    kilos = table.Column<double>(type: "double precision", nullable: false),
                    total = table.Column<double>(type: "double precision", nullable: false),
                    cliente_id = table.Column<int>(type: "integer", nullable: false),
                    empleado_id = table.Column<int>(type: "integer", nullable: false),
                    referencia = table.Column<string>(type: "text", nullable: false),
                    caja_id = table.Column<int>(type: "integer", nullable: false),
                    estatus_orden_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ordenes", x => x.id);
                    table.ForeignKey(
                        name: "fk_ordenes_cajas_caja_id",
                        column: x => x.caja_id,
                        principalTable: "cajas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ordenes_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ordenes_empleados_empleado_id",
                        column: x => x.empleado_id,
                        principalTable: "empleados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ordenes_estatus_orden_estatus_orden_id",
                        column: x => x.estatus_orden_id,
                        principalTable: "estatus_orden",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items_orden",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    precio_unitario = table.Column<double>(type: "double precision", nullable: false),
                    total = table.Column<double>(type: "double precision", nullable: false),
                    kilos = table.Column<double>(type: "double precision", nullable: false),
                    producto_id = table.Column<int>(type: "integer", nullable: false),
                    orden_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_items_orden", x => x.id);
                    table.ForeignKey(
                        name: "fk_items_orden_ordenes_orden_id",
                        column: x => x.orden_id,
                        principalTable: "ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_items_orden_productos_producto_id",
                        column: x => x.producto_id,
                        principalTable: "productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    subtotal = table.Column<double>(type: "double precision", nullable: false),
                    total = table.Column<double>(type: "double precision", nullable: false),
                    iva = table.Column<double>(type: "double precision", nullable: false),
                    orden_id = table.Column<int>(type: "integer", nullable: false),
                    sucursal_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ventas", x => x.id);
                    table.ForeignKey(
                        name: "fk_ventas_ordenes_orden_id",
                        column: x => x.orden_id,
                        principalTable: "ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ventas_sucursales_sucursal_id",
                        column: x => x.sucursal_id,
                        principalTable: "sucursales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pagos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    monto_recibido = table.Column<double>(type: "double precision", nullable: false),
                    cambio = table.Column<double>(type: "double precision", nullable: false),
                    cliente_id = table.Column<int>(type: "integer", nullable: false),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    metodo_pago_id = table.Column<int>(type: "integer", nullable: false),
                    venta_id = table.Column<int>(type: "integer", nullable: false),
                    caja_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pagos", x => x.id);
                    table.ForeignKey(
                        name: "fk_pagos_cajas_caja_id",
                        column: x => x.caja_id,
                        principalTable: "cajas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pagos_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pagos_metodos_pago_metodo_pago_id",
                        column: x => x.metodo_pago_id,
                        principalTable: "metodos_pago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pagos_ventas_venta_id",
                        column: x => x.venta_id,
                        principalTable: "ventas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "created_at", "deleted_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Pollo", null },
                    { 2, null, null, "Marinado", null }
                });

            migrationBuilder.InsertData(
                table: "direcciones",
                columns: new[] { "id", "calle", "codigo_postal", "colonia", "created_at", "deleted_at", "estado", "numero_externo", "numero_interior", "updated_at" },
                values: new object[] { 1, "calle", "09660", "Bugambilia", null, null, null, "1", "2", null });

            migrationBuilder.InsertData(
                table: "estatus_orden",
                columns: new[] { "id", "created_at", "deleted_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "CREADA", null },
                    { 2, null, null, "PAGADA", null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "created_at", "deleted_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "ADMINISTRADOR", null },
                    { 2, null, null, "CAJA", null },
                    { 3, null, null, "ORDENES", null }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "id", "created_at", "deleted_at", "direccion_id", "nombre_comercial", "razon_social", "rfc", "updated_at" },
                values: new object[] { 1, null, null, 1, "AARON", "AARON", "GOMA971007BD8", null });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] { "id", "categoria_id", "created_at", "deleted_at", "nombre", "precio_unitario", "updated_at" },
                values: new object[] { 1, 1, null, null, "POLLO ADOBADO", 0.0, null });

            migrationBuilder.InsertData(
                table: "sucursales",
                columns: new[] { "id", "created_at", "deleted_at", "direccion_id", "nombre", "updated_at" },
                values: new object[] { 1, null, null, 1, "AZTECAS", null });

            migrationBuilder.InsertData(
                table: "cajas",
                columns: new[] { "id", "created_at", "deleted_at", "efectivo_disponible", "hostname", "ip", "numero_caja", "sucursal_id", "updated_at" },
                values: new object[] { 1, null, null, 0.0, "caja", "192.168.0.2", "1", 1, null });

            migrationBuilder.InsertData(
                table: "empleados",
                columns: new[] { "id", "apellido_materno", "apellido_paterno", "created_at", "deleted_at", "nombre", "sucursal_id", "updated_at" },
                values: new object[] { 1, "López", "Hernandez", null, null, "Rogelio", 1, null });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "id", "correo", "nombre", "password", "rol_id", "sucursal_id", "token" },
                values: new object[,]
                {
                    { 1, "admin@ml-grupo.com.mx", "Admin", "$2a$12$yRELEkrsM7oesblMcmu60uR67uxaNQAhd3cMU7ZthsnQmRQH6EIYe", 1, 1, null },
                    { 2, "caja1@ml-grupo.com.mx", "Caja", "$2a$12$yRELEkrsM7oesblMcmu60uR67uxaNQAhd3cMU7ZthsnQmRQH6EIYe", 2, 1, null },
                    { 3, "ordenes1@ml-grupo.com.mx", "Ordenes", "$2a$12$yRELEkrsM7oesblMcmu60uR67uxaNQAhd3cMU7ZthsnQmRQH6EIYe", 3, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_cajas_sucursal_id",
                table: "cajas",
                column: "sucursal_id");

            migrationBuilder.CreateIndex(
                name: "ix_clientes_direccion_id",
                table: "clientes",
                column: "direccion_id");

            migrationBuilder.CreateIndex(
                name: "ix_cortes_caja_id",
                table: "cortes",
                column: "caja_id");

            migrationBuilder.CreateIndex(
                name: "ix_empleados_sucursal_id",
                table: "empleados",
                column: "sucursal_id");

            migrationBuilder.CreateIndex(
                name: "ix_items_caja_caja_id",
                table: "items_caja",
                column: "caja_id");

            migrationBuilder.CreateIndex(
                name: "ix_items_caja_empleado_id",
                table: "items_caja",
                column: "empleado_id");

            migrationBuilder.CreateIndex(
                name: "ix_items_orden_orden_id",
                table: "items_orden",
                column: "orden_id");

            migrationBuilder.CreateIndex(
                name: "ix_items_orden_producto_id",
                table: "items_orden",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "ix_ordenes_caja_id",
                table: "ordenes",
                column: "caja_id");

            migrationBuilder.CreateIndex(
                name: "ix_ordenes_cliente_id",
                table: "ordenes",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "ix_ordenes_empleado_id",
                table: "ordenes",
                column: "empleado_id");

            migrationBuilder.CreateIndex(
                name: "ix_ordenes_estatus_orden_id",
                table: "ordenes",
                column: "estatus_orden_id");

            migrationBuilder.CreateIndex(
                name: "ix_pagos_caja_id",
                table: "pagos",
                column: "caja_id");

            migrationBuilder.CreateIndex(
                name: "ix_pagos_cliente_id",
                table: "pagos",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "ix_pagos_metodo_pago_id",
                table: "pagos",
                column: "metodo_pago_id");

            migrationBuilder.CreateIndex(
                name: "ix_pagos_venta_id",
                table: "pagos",
                column: "venta_id");

            migrationBuilder.CreateIndex(
                name: "ix_productos_categoria_id",
                table: "productos",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "ix_sucursales_direccion_id",
                table: "sucursales",
                column: "direccion_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuarios_rol_id",
                table: "usuarios",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "ix_usuarios_sucursal_id",
                table: "usuarios",
                column: "sucursal_id");

            migrationBuilder.CreateIndex(
                name: "ix_ventas_orden_id",
                table: "ventas",
                column: "orden_id");

            migrationBuilder.CreateIndex(
                name: "ix_ventas_sucursal_id",
                table: "ventas",
                column: "sucursal_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cortes");

            migrationBuilder.DropTable(
                name: "items_caja");

            migrationBuilder.DropTable(
                name: "items_orden");

            migrationBuilder.DropTable(
                name: "pagos");

            migrationBuilder.DropTable(
                name: "referecias_orden");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "metodos_pago");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "ordenes");

            migrationBuilder.DropTable(
                name: "cajas");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "estatus_orden");

            migrationBuilder.DropTable(
                name: "sucursales");

            migrationBuilder.DropTable(
                name: "direcciones");
        }
    }
}
