using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storage.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedStore = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    StoreEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreEntityId",
                        column: x => x.StoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false),
                    Crust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "Orders",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Address", "Name" },
                values: new object[] { 1L, null, "Home Slice" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Address", "Name" },
                values: new object[] { 2L, null, "Pinthouse Pizza Co" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderEntityId",
                table: "Pizzas",
                column: "OrderEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
