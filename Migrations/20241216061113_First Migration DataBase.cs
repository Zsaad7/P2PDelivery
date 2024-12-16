using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTPDelivery.Server.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrationDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carriers",
                columns: table => new
                {
                    IdCarrier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carriers", x => x.IdCarrier);
                });

            migrationBuilder.CreateTable(
                name: "senders",
                columns: table => new
                {
                    IdSender = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_senders", x => x.IdSender);
                });

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    IdDocument = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CarrierIdCarrier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.IdDocument);
                    table.ForeignKey(
                        name: "FK_documents_carriers_CarrierIdCarrier",
                        column: x => x.CarrierIdCarrier,
                        principalTable: "carriers",
                        principalColumn: "IdCarrier");
                });

            migrationBuilder.CreateTable(
                name: "trip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WayTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuggageCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierIdCarrier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trip_carriers_CarrierIdCarrier",
                        column: x => x.CarrierIdCarrier,
                        principalTable: "carriers",
                        principalColumn: "IdCarrier");
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickupLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deadline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierIdCarrier = table.Column<int>(type: "int", nullable: true),
                    SenderIdSender = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_items_carriers_CarrierIdCarrier",
                        column: x => x.CarrierIdCarrier,
                        principalTable: "carriers",
                        principalColumn: "IdCarrier");
                    table.ForeignKey(
                        name: "FK_items_senders_SenderIdSender",
                        column: x => x.SenderIdSender,
                        principalTable: "senders",
                        principalColumn: "IdSender");
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    IdPayement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePaiement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModePaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferencePaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierIdCarrier = table.Column<int>(type: "int", nullable: true),
                    SenderIdSender = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.IdPayement);
                    table.ForeignKey(
                        name: "FK_payments_carriers_CarrierIdCarrier",
                        column: x => x.CarrierIdCarrier,
                        principalTable: "carriers",
                        principalColumn: "IdCarrier");
                    table.ForeignKey(
                        name: "FK_payments_senders_SenderIdSender",
                        column: x => x.SenderIdSender,
                        principalTable: "senders",
                        principalColumn: "IdSender");
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    IdReview = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionReview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarrierIdCarrier = table.Column<int>(type: "int", nullable: true),
                    SenderIdSender = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.IdReview);
                    table.ForeignKey(
                        name: "FK_reviews_carriers_CarrierIdCarrier",
                        column: x => x.CarrierIdCarrier,
                        principalTable: "carriers",
                        principalColumn: "IdCarrier");
                    table.ForeignKey(
                        name: "FK_reviews_senders_SenderIdSender",
                        column: x => x.SenderIdSender,
                        principalTable: "senders",
                        principalColumn: "IdSender");
                });

            migrationBuilder.CreateIndex(
                name: "IX_documents_CarrierIdCarrier",
                table: "documents",
                column: "CarrierIdCarrier");

            migrationBuilder.CreateIndex(
                name: "IX_items_CarrierIdCarrier",
                table: "items",
                column: "CarrierIdCarrier");

            migrationBuilder.CreateIndex(
                name: "IX_items_SenderIdSender",
                table: "items",
                column: "SenderIdSender");

            migrationBuilder.CreateIndex(
                name: "IX_payments_CarrierIdCarrier",
                table: "payments",
                column: "CarrierIdCarrier");

            migrationBuilder.CreateIndex(
                name: "IX_payments_SenderIdSender",
                table: "payments",
                column: "SenderIdSender");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_CarrierIdCarrier",
                table: "reviews",
                column: "CarrierIdCarrier");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_SenderIdSender",
                table: "reviews",
                column: "SenderIdSender");

            migrationBuilder.CreateIndex(
                name: "IX_trip_CarrierIdCarrier",
                table: "trip",
                column: "CarrierIdCarrier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "trip");

            migrationBuilder.DropTable(
                name: "senders");

            migrationBuilder.DropTable(
                name: "carriers");
        }
    }
}
