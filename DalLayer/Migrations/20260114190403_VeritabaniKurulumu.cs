using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DalLayer.Migrations
{
    public partial class VeritabaniKurulumu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Masalar",
                columns: table => new
                {
                    MasaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasaNo = table.Column<string>(nullable: true),
                    Kapasite = table.Column<int>(nullable: false),
                    Konum = table.Column<string>(nullable: true),
                    Durum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masalar", x => x.MasaID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(nullable: true),
                    Kategori = table.Column<string>(nullable: true),
                    Fiyat = table.Column<decimal>(nullable: false),
                    Stok = table.Column<int>(nullable: false),
                    Durum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasaID = table.Column<int>(nullable: false),
                    UrunID = table.Column<int>(nullable: false),
                    Adet = table.Column<int>(nullable: false),
                    SiparisTarihi = table.Column<DateTime>(nullable: false),
                    ToplamTutar = table.Column<decimal>(nullable: false),
                    Durum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Siparisler_Masalar_MasaID",
                        column: x => x.MasaID,
                        principalTable: "Masalar",
                        principalColumn: "MasaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Siparisler_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MasaID",
                table: "Siparisler",
                column: "MasaID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_UrunID",
                table: "Siparisler",
                column: "UrunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Masalar");

            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
