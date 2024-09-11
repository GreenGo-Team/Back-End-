using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenGo.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Centers",
                columns: table => new
                {
                    Center_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centers", x => x.Center_ID);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Container_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Container_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Content_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Content_ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RewardPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContents",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContents", x => new { x.CustomerId, x.ContentId });
                    table.ForeignKey(
                        name: "FK_CustomerContents_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Content_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerContents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ScanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecyclabilityStatus = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Reward_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PointsRequied = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Reward_ID);
                    table.ForeignKey(
                        name: "FK_Rewards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Process_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    CenterId = table.Column<int>(type: "int", nullable: false),
                    ContainerId = table.Column<int>(type: "int", nullable: false),
                    Recycling_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Process_ID);
                    table.ForeignKey(
                        name: "FK_Processes_Centers_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Centers",
                        principalColumn: "Center_ID");
                    table.ForeignKey(
                        name: "FK_Processes_Containers_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "Containers",
                        principalColumn: "Container_ID");
                    table.ForeignKey(
                        name: "FK_Processes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID");
                    table.ForeignKey(
                        name: "FK_Processes_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContents_ContentId",
                table: "CustomerContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CustomerId",
                table: "Items",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_CenterId",
                table: "Processes",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_ContainerId",
                table: "Processes",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_CustomerId",
                table: "Processes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_ItemsId",
                table: "Processes",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_CustomerId",
                table: "Rewards",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerContents");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Centers");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
